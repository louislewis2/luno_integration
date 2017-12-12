namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class TickerResponse
    {
        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }
    }
}
