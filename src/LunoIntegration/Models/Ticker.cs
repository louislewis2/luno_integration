namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class Ticker
    {
        #region Properties

        [JsonProperty("ask")]
        public double Ask { get; set; }

        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }

        [JsonProperty("bid")]
        public double Bid { get; set; }

        [JsonProperty("rolling_24_hour_volume")]
        public double RollingDailyVolume { get; set; }

        [JsonProperty("last_trade")]
        public double LastTrade { get; set; }

        [JsonProperty("pair")]
        public string Pair { get; set; }

        #endregion Properties
    }
}
