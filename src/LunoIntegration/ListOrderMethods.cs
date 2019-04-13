namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Enums;
    using LunoIntegration.Models;

    public static class ListOrderMethods
    {
        #region Fields

        private const string ResourceBase = "/listorders";

        #endregion Fields

        #region Methods

        public static async Task<OrdersResponse> GetOrdersAsync(this LunoClient lunoClient, string currencyPair, OrderStates orderState)
        {
            return await lunoClient.GetAsync<OrdersResponse>(ResourceBase, $"state={orderState}&pair={currencyPair}");
        }

        public static async Task<OrdersResponse> GetOrdersAsync(this LunoClient lunoClient, OrderStates orderState)
        {
            return await lunoClient.GetAsync<OrdersResponse>(ResourceBase, $"state={orderState}");
        }

        public static async Task<OrdersResponse> GetOrdersAsync(this LunoClient lunoClient, string currencyPair)
        {
            return await lunoClient.GetAsync<OrdersResponse>(ResourceBase, $"pair={currencyPair}");
        }

        public static async Task<OrdersResponse> GetOrdersAsync(this LunoClient lunoClient)
        {
            return await lunoClient.GetAsync<OrdersResponse>(ResourceBase, queryString: string.Empty);
        }

        #endregion Methods
    }
}
