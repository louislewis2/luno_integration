namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class OrderBookMethods
    {
        #region Fields

        private const string ResourceBase = "/orderbook";

        #endregion Fields

        #region Methods

        public static async Task<OrderBook> GetOrderBookAsync(this LunoClient lunoClient, string pair)
        {
            return await lunoClient.GetAsync<OrderBook>(ResourceBase, $"?pair={pair}");
        }

        #endregion Methods
    }
}
