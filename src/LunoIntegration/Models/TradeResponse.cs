namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class TradeResponse
    {
        #region Properties

        [JsonProperty("trades")]
        public Trade[] Trades { get; set; }

        #endregion Properties
    }
}
