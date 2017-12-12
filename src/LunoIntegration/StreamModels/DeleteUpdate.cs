namespace LunoIntegration.StreamModels
{
    using Newtonsoft.Json;

    public class DeleteUpdate
    {
        #region Properties

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        #endregion Properties
    }
}
