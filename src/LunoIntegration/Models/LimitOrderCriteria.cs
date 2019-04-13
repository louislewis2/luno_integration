namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    using LunoIntegration.Enums;

    public class LimitOrderCriteria
    {
        #region Properties

        [JsonProperty(PropertyName = "pair")]
        public string Pair { get; set; }

        [JsonProperty(PropertyName = "type")]
        public OrderTypes Type { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public string Volume { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "base_account_id")]
        public string BaseAccountId { get; set; }

        [JsonProperty(PropertyName = "counter_account_id")]
        public string CounterAccountId { get; set; }

        [JsonProperty(PropertyName = "post_only")]
        public bool PostOnly { get; set; }

        #endregion Properties
    }
}
