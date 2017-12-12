namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class Transaction
    {
        #region Properties

        [JsonProperty("row_index")]
        public int RowIndex { get; set; }

        [JsonProperty("timestamp")]
        public double TimeStamp { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }

        [JsonProperty("balance_delta")]
        public double BalanceDelta { get; set; }

        [JsonProperty("available_delta")]
        public double AvailableDelta { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #endregion Properties
    }
}
