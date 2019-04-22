namespace LunoIntegration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using LunoIntegration.Enums;

    public class MarketOrderCriteria
    {
        #region Properties

        [JsonProperty(PropertyName = "pair")]
        public string Pair { get; set; }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderTypes Type { get; set; }

        [JsonProperty(PropertyName = "counter_volume")]
        public decimal CounterVolume { get; set; }

        [JsonProperty(PropertyName = "base_volume")]
        public decimal BaseVolume { get; set; }

        [JsonProperty(PropertyName = "base_account_id")]
        public string BaseAccountId { get; set; }

        [JsonProperty(PropertyName = "counter_account_id")]
        public string CounterAccountId { get; set; }

        #endregion Properties
    }
}
