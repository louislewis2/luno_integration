namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class LiveOrder
    {
        #region Properties

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        #endregion Properties
    }
}
