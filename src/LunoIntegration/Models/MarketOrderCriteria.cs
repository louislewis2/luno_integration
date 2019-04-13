namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    using LunoIntegration.Enums;

    public class MarketOrderCriteria
    {
        #region Properties

        [JsonProperty(PropertyName = "pair")]
        public string Pair { get; set; }

        [JsonProperty(PropertyName = "type")]
        public OrderTypes Type { get; set; }

        [JsonProperty(PropertyName = "counter_volume")]
        public string CounterVolume { get; set; }

        [JsonProperty(PropertyName = "base_volume")]
        public string BaseVolume { get; set; }

        [JsonProperty(PropertyName = "base_account_id")]
        public string BaseAccountId { get; set; }

        [JsonProperty(PropertyName = "counter_account_id")]
        public string CounterAccountId { get; set; }

        #endregion Properties
    }
}
