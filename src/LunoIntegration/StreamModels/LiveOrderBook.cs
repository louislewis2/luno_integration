namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class LiveOrderBook
    {
        [JsonProperty("sequence")]
        public double Sequence { get; set; }

        [JsonProperty("bids")]
        public LiveOrder[] Bids { get; set; }

        [JsonProperty("asks")]
        public LiveOrder[] Asks { get; set; }
    }
}
