namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class TransactionMethods
    {
        #region Fields

        private const string ResourceBase = "/accounts";

        #endregion Fields

        #region Methods

        public static async Task<AccountTransactionResponse> GetAccountTransactionsAsync(this LunoClient lunoClient, string accountId, int minRow, int maxRow)
        {
            return await lunoClient.GetAsync<AccountTransactionResponse>($"{ResourceBase}/{accountId}/transactions", $"?min_row={minRow}&max_row={maxRow}");
        }

        public static async Task<PendingTransactionResponse> GetAccountPendingTransactionsAsync(this LunoClient lunoClient, string accountId)
        {
            return await lunoClient.GetAsync<PendingTransactionResponse>($"{ResourceBase}/{accountId}/pending", null);
        }

        #endregion Methods
    }
}
