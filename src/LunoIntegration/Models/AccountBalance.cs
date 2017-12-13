namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class AccountBalance
    {
        #region Properties

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("reserved")]
        public double Reserved { get; set; }

        [JsonProperty("unconfirmed")]
        public double Unconfirmed { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        #endregion Properties
    }
}
