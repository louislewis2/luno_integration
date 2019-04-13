namespace LunoIntegration
{
    using System;
    using System.Net;
    using System.Text;
    using System.Net.Http;
    using System.Threading;
    using System.Net.WebSockets;
    using System.Threading.Tasks;
    using System.Net.Http.Headers;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    using LunoIntegration.Models;

    public class LunoClient
    {
        #region Fields

        private ClientWebSocket webSocket;
        private readonly int version = 1;
        private readonly HttpClient httpClient;
        private const string baseUrl = "https://api.mybitx.com/";
        private CancellationToken socketCancellationToken = CancellationToken.None;

        private string key;
        private string secret;
        private Action<string> orderBookReceivedAction;
        private Action<string> orderUpdateReceivedAction;
        private Action disconnectedAction;

        #endregion Fields

        #region Constructor

        public LunoClient(string key, string secret)
        {
            this.key = key;
            this.secret = secret;
            this.httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
        }

        #endregion Constructor

        #region Methods

        public async Task<T> PostAsync<T>(string resourceUrl, object data) where T : class
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
            {
                throw new ArgumentException("Resource Url Cannot Be Emtpty");
            }

            var content = data == null ? new StringContent("", Encoding.UTF8, "application/json") : new StringContent(SerializeToJson(data), Encoding.UTF8, "application/json");

            this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{this.key}:{this.secret}")));
            this.httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Luno_Integration_Client", "0.0.1"));
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var requestResult = await this.httpClient.PostAsync(resourceUrl, content);
            if (requestResult.StatusCode == HttpStatusCode.OK)
            {
                return requestResult.Deserialize<T>();
            }

            var message = requestResult.TryReadContent();

            throw string.IsNullOrWhiteSpace(message) ? new Exception(requestResult.ReasonPhrase) : new Exception(requestResult.ReasonPhrase, new Exception(message));
        }

        public async Task<T> GetAsync<T>(string resourceUrl, string queryString) where T : class
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
            {
                throw new ArgumentException("Resource Url Cannot Be Emtpty");
            }

            var finalResourceUrl = string.IsNullOrWhiteSpace(queryString) ? string.Format("api/{0}{1}", this.version, resourceUrl) : string.Format("api/{0}{1}{2}", this.version, resourceUrl, queryString);

            this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{this.key}:{this.secret}")));
            this.httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Luno_Integration_Client", "0.0.1"));

            var requestResult = await this.httpClient.GetAsync(finalResourceUrl);
            if (requestResult.StatusCode == HttpStatusCode.OK)
            {
                return requestResult.Deserialize<T>();
            }

            var message = requestResult.TryReadContent();

            throw string.IsNullOrWhiteSpace(message) ? new Exception(requestResult.ReasonPhrase) : new Exception(requestResult.ReasonPhrase, new Exception(message));
        }

        public async Task ConnectLive(string pair, Action<string> orderBookReceivedAction, Action<string> orderUpdateReceivedAction, Action disconnectedAction, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.socketCancellationToken = cancellationToken;
            this.orderBookReceivedAction = orderBookReceivedAction;
            this.orderUpdateReceivedAction = orderUpdateReceivedAction;
            this.disconnectedAction = disconnectedAction;

            await Task.Factory.StartNew(async () => await this.CreateSocketConnection(pair: pair), this.socketCancellationToken);
        }

        public async Task DisconnectLive()
        {
            if (this.webSocket.State == WebSocketState.Open)
            {
                await this.webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, this.socketCancellationToken);
            }
        }

        #endregion Methods

        #region Private Methods

        private async Task CreateSocketConnection(string pair)
        {
            var uri = new Uri(uriString: $"wss://ws.luno.com/api/1/stream/{pair}");
            this.webSocket = new ClientWebSocket();
            this.webSocket.Options.KeepAliveInterval = TimeSpan.FromSeconds(10);

            await this.webSocket.ConnectAsync(uri: uri, cancellationToken: this.socketCancellationToken);

            this.SendCredentials();
            this.StartListen();
        }

        private async void StartListen()
        {
            var buffer = new byte[51200];

            try
            {
                var stringResult = new StringBuilder();

                while (!this.socketCancellationToken.IsCancellationRequested && this.webSocket.State == WebSocketState.Open)
                {
                    var result = await this.webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), this.socketCancellationToken);

                    var str = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    stringResult.Append(str);

                    if (result.EndOfMessage)
                    {
                        this.ProcessMessage(stringResult);
                    }
                }
            }
            catch (Exception)
            {
                this.Disconnected();
            }
            finally
            {
                this.webSocket.Dispose();
            }
        }

        private async Task SendMessage(string message)
        {
            if (this.webSocket.State != WebSocketState.Open)
            {
                throw new Exception("Connection is not open.");
            }

            var sendBuffer = new ArraySegment<Byte>(Encoding.UTF8.GetBytes(message.ToString()));
            await this.webSocket.SendAsync(sendBuffer, WebSocketMessageType.Text, true, this.socketCancellationToken);
        }

        private async void SendCredentials()
        {
            var credentials = new StreamCredentials
            {
                Key = this.key,
                Secret = this.secret
            };

            await this.SendMessage(JsonConvert.SerializeObject(value: credentials));
        }

        private void ProcessMessage(StringBuilder stringBuilder)
        {
            var finalString = stringBuilder.ToString();

            if (finalString.Contains("asks") || finalString.Contains("bids"))
            {
                this.orderBookReceivedAction?.Invoke(obj: finalString);
            }
            else
            {
                this.orderUpdateReceivedAction?.Invoke(obj: finalString);
            }

            stringBuilder.Clear();
        }

        private void Disconnected()
        {
            this.disconnectedAction?.Invoke();
        }

        private static string SerializeToJson<T>(T obj)
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), NullValueHandling = NullValueHandling.Ignore };

            return JsonConvert.SerializeObject(obj, settings);
        }

        #endregion Private Methods
    }
}
