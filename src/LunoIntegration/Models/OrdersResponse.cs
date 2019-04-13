namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class OrdersResponse
    {
        #region Properties

        [JsonProperty(PropertyName = "orders")]
        public Order[] Orders { get; set; }

        #endregion Properties
    }
}
