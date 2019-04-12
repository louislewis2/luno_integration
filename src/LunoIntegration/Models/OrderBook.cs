namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class OrderBook
    {
        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }

        [JsonProperty("bids")]
        public OrderBookEntry[] Bids { get; set; }

        [JsonProperty("asks")]
        public OrderBookEntry[] Asks { get; set; }
    }
}
