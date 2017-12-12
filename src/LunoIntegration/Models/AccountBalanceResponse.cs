namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class AccountBalanceResponse
    {
        #region Properties

        [JsonProperty("balance")]
        public AccountBalance[] Balances { get; set; }

        #endregion Properties
    }
}
