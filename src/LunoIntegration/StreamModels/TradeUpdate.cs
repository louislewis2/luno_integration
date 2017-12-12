namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class TradeUpdate
    {
        #region Properties

        [JsonProperty("base")]
        public double Base { get; set; }

        [JsonProperty("counter")]
        public double Counter { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        #endregion Properties
    }
}
