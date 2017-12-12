namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class TickersMethods
    {
        #region Fields

        private const string ResourceBase = "/tickers";

        #endregion Fields

        #region Methods

        public static async Task<TickerResponse> GetTickersAsync(this LunoClient lunoClient)
        {
            return await lunoClient.GetAsync<TickerResponse>(ResourceBase, null);
        }

        #endregion Methods
    }
}
