namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class LimitOrderMethods
    {
        #region Fields

        private const string ResourceBase = "/postorder";

        #endregion Fields

        #region Methods

        public static async Task<CreateOrderResponse> PostLimitOrderAsync(this LunoClient lunoClient, LimitOrderCriteria limitOrderCriteria)
        {
            return await lunoClient.PostAsync<CreateOrderResponse>(ResourceBase, limitOrderCriteria);
        }

        #endregion Methods
    }
}
