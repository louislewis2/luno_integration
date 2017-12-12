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
        public string Balance { get; set; }

        [JsonProperty("reserved")]
        public string Reserved { get; set; }

        [JsonProperty("unconfirmed")]
        public string Unconfirmed { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        #endregion Properties
    }
}
