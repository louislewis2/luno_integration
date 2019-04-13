namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class StopOrderMethods
    {
        #region Fields

        private const string ResourceBase = "/stoporder";

        #endregion Fields

        #region Methods

        public static async Task<StopOrderResponse> StopOrderAsync(this LunoClient lunoClient, string orderId)
        {
            var stopOrderCriteria = new StopOrderCriteria { OrderId = orderId };

            return await lunoClient.PostAsync<StopOrderResponse>(ResourceBase, stopOrderCriteria);
        }

        #endregion Methods
    }
}
