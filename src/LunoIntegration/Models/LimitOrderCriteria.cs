namespace LunoIntegration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using LunoIntegration.Enums;

    public class LimitOrderCriteria
    {
        #region Properties

        [JsonProperty(PropertyName = "pair")]
        public string Pair { get; set; }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderTypes Type { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public decimal Volume { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "base_account_id")]
        public string BaseAccountId { get; set; }

        [JsonProperty(PropertyName = "counter_account_id")]
        public string CounterAccountId { get; set; }

        [JsonProperty(PropertyName = "post_only")]
        public bool PostOnly { get; set; }

        #endregion Properties
    }
}
