namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class CreateOrderResponse
    {
        #region Properties

        [JsonProperty(PropertyName = "order_id")]
        public string OrderId { get; set; }

        #endregion Properties
    }
}
