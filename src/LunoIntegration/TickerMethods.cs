namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class TickerMethods
    {
        #region Fields

        private const string ResourceBase = "/ticker";

        #endregion Fields

        #region Methods

        public static async Task<Ticker> GetTickerAsync(this LunoClient lunoClient, string pair)
        {
            return await lunoClient.GetAsync<Ticker>(ResourceBase, $"?pair={pair}");
        }

        #endregion Methods
    }
}
