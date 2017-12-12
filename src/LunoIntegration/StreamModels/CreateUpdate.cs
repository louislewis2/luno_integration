namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class CreateUpdate
    {
        #region Properties

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        #endregion Properties
    }
}
