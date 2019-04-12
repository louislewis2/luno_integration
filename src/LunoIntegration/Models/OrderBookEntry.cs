namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class OrderBookEntry
    {
        #region Properties

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        #endregion Properties
    }
}
