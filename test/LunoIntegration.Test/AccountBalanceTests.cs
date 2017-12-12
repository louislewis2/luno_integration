namespace LunoIntegration.Test
{
    using System.Threading.Tasks;

    using Xunit;

    public class AccountBalanceTests : TestBase
    {
        #region Methods

        [Fact]
        public async Task Can_Get_AccountBalances()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var accountBalanceResponse = await client.GetAccountBalancesAsync();

            // Assert
            Assert.NotNull(accountBalanceResponse);
            Assert.NotEmpty(accountBalanceResponse.Balances);
        }

        #endregion Methods
    }
}
