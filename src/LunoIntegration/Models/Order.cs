namespace LunoIntegration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using LunoIntegration.Enums;

    public class Order
    {
        #region Properties

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("creation_timestamp")]
        public double CreationTimeStamp { get; set; }

        [JsonProperty("expiration_timestamp")]
        public double ExpirationTimeStamp { get; set; }

        [JsonProperty("completed_timestamp")]
        public double CompletedTimeStamp { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderTypes Type { get; set; }

        [JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStates State { get; set; }

        [JsonProperty("limit_price")]
        public double LimitPrice { get; set; }

        [JsonProperty("limit_volume")]
        public double LimitVolume { get; set; }

        [JsonProperty("base")]
        public double Base { get; set; }

        [JsonProperty("counter")]
        public double Counter { get; set; }

        [JsonProperty("fee_base")]
        public double FeeBase { get; set; }

        [JsonProperty("fee_counter")]
        public double FeeCounter { get; set; }

        #endregion Properties
    }
}
