namespace LunoIntegration.Test
{
    using System.Threading.Tasks;

    using Xunit;

    public class TransactionTests : TestBase
    {
        #region Methods

        [Fact]
        public async Task Can_Get_Transactions()
        {
            // Arrange
            var client = this.GetClient();
            var minRow = 1;
            var maxRow = 100;

            // Act
            var accountBalanceResponse = await client.GetAccountBalancesAsync();
            var accountTransactionResponse = await client.GetAccountTransactionsAsync(accountId: accountBalanceResponse.Balances[0].AccountId, minRow: minRow, maxRow: maxRow);

            // Assert
            Assert.NotNull(accountTransactionResponse);
            Assert.NotEmpty(accountTransactionResponse.Transactions);
        }

        [Fact]
        public async Task Can_Get_Pending_Transactions()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var accountBalanceResponse = await client.GetAccountBalancesAsync();
            var pendingTransactionResponse = await client.GetAccountPendingTransactionsAsync(accountId: accountBalanceResponse.Balances[0].AccountId);

            // Assert
            Assert.NotNull(pendingTransactionResponse);
            Assert.Empty(pendingTransactionResponse.Transactions);
        }

        #endregion Methods
    }
}
