namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class Ticker
    {
        #region Properties

        [JsonProperty("ask")]
        public string Ask { get; set; }

        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }

        [JsonProperty("bid")]
        public string Bid { get; set; }

        [JsonProperty("rolling_24_hour_volume")]
        public string RollingDailyVolume { get; set; }

        [JsonProperty("last_trade")]
        public string LastTrade { get; set; }

        [JsonProperty("pair")]
        public string Pair { get; set; }

        #endregion Properties
    }
}
