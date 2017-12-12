namespace LunoIntegration.Models
{
    using Newtonsoft.Json;

    public class Order
    {
        #region Properties

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        #endregion Properties
    }
}
