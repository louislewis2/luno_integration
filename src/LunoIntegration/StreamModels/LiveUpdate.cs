namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class LiveUpdate
    {
        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("trade_updates")]
        public double TradeUpdates { get; set; }

        [JsonProperty("create_update")]
        public double CreateUpdate { get; set; }

        [JsonProperty("delete_update")]
        public double DeleteUpdate { get; set; }

        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }
    }
}
