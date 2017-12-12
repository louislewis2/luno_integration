namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class LiveUpdate
    {
        [JsonProperty("sequence")]
        public double Sequence { get; set; }

        [JsonProperty("trade_updates")]
        public TradeUpdate[] TradeUpdates { get; set; }

        [JsonProperty("create_update")]
        public CreateUpdate CreateUpdate { get; set; }

        [JsonProperty("delete_update")]
        public DeleteUpdate DeleteUpdate { get; set; }

        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }
    }
}
