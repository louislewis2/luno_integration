namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class Trade
    {
        #region Properties

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("is_buy")]
        public bool IsBuy { get; set; }

        #endregion Properties
    }
}
