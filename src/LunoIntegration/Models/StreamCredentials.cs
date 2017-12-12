namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class StreamCredentials
    {
        #region Properties

        [JsonProperty("api_key_id")]
        public string Key { get; set; }

        [JsonProperty("api_key_secret")]
        public string Secret { get; set; }

        #endregion Properties
    }
}
