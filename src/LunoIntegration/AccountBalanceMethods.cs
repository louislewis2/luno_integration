namespace LunoIntegration
{
    using System.Threading.Tasks;

    using LunoIntegration.Models;

    public static class AccountBalanceMethods
    {
        #region Fields

        private const string ResourceBase = "/balance";

        #endregion Fields

        #region Methods

        public static async Task<AccountBalanceResponse> GetAccountBalancesAsync(this LunoClient lunoClient)
        {
            return await lunoClient.GetAsync<AccountBalanceResponse>(ResourceBase, null);
        }

        #endregion Methods
    }
}
