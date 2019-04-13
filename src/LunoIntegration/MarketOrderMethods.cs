namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class MarketOrderMethods
    {
        #region Fields

        private const string ResourceBase = "/marketorder";

        #endregion Fields

        #region Methods

        public static async Task<CreateOrderResponse> PostMarketOrderAsync(this LunoClient lunoClient, MarketOrderCriteria marketOrderCriteria)
        {
            return await lunoClient.PostAsync<CreateOrderResponse>(ResourceBase, marketOrderCriteria);
        }

        #endregion Methods
    }
}
