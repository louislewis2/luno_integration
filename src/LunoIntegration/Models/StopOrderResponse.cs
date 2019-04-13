namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class StopOrderResponse
    {
        #region Properties

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        #endregion Properties
    }
}
