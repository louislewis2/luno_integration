namespace System.Net.Http
{
    using Newtonsoft.Json;

    public static class HttpResponseExtensions
    {
        public static T Deserialize<T>(this HttpResponseMessage response) where T : class
        {
            var settings = new JsonSerializerSettings();
            settings.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor;

            var stream = response.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<T>(stream, settings);

            return item;
        }

        public static string TryReadContent(this HttpResponseMessage response)
        {
            string message = string.Empty;

            try
            {
                message = response.Content.ReadAsStringAsync().Result;
            }
            catch { }

            return message;
        }
    }
}
