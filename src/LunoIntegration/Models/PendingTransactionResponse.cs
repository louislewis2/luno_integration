namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class PendingTransactionResponse
    {
        #region Properties

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("pending")]
        public Transaction[] Transactions { get; set; }

        #endregion Properties
    }
}
