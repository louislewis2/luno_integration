namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class OrderMethods
    {
        #region Fields

        private const string ResourceBase = "/orders";

        #endregion Fields

        #region Methods

        public static async Task<Order> GetOrderAsync(this LunoClient lunoClient, string orderId)
        {
            return await lunoClient.GetAsync<Order>(ResourceBase, orderId);
        }

        #endregion Methods
    }
}
