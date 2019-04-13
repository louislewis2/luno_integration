namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class StopOrderCriteria
    {
        #region Properties

        [JsonProperty(PropertyName = "order_id")]
        public string OrderId { get; set; }

        #endregion Properties
    }
}
