namespace LunoIntegration
{
    using System;
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class TradeMethods
    {
        #region Fields

        private const string ResourceBase = "/trades";

        #endregion Fields

        #region Methods

        public static async Task<TradeResponse> GetTradesAsync(this LunoClient lunoClient, string pair, int? since = null)
        {
            string queryString = since.HasValue ? $"?pair={pair}&since={since}" : $"?pair={pair}";

            return await lunoClient.GetAsync<TradeResponse>(ResourceBase, queryString);
        }

        public static async Task<TradeResponse> GetTradesAsync(this LunoClient lunoClient, string pair, DateTime since)
        {
            return await lunoClient.GetAsync<TradeResponse>(ResourceBase, $"?pair={pair}&since={since.DateTimeToUnixTimestamp()}");
        }

        #endregion Methods
    }
}
