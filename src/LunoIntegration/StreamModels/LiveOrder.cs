namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class LiveOrder
    {
        #region Properties

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        #endregion Properties
    }
}
