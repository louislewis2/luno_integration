namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class AccountTransactionResponse
    {
        #region Properties

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }

        #endregion Properties
    }
}
