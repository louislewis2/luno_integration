namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class OrderBook
    {
        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }

        [JsonProperty("bids")]
        public Order[] Bids { get; set; }

        [JsonProperty("asks")]
        public Order[] Asks { get; set; }
    }
}
