namespace LunoIntegration.Test
{
    using System.Threading.Tasks;

    using Xunit;

    public class TickersTests : TestBase
    {
        #region Methods

        [Fact]
        public async Task Can_Get_Tickers()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var tickerResponse = await client.GetTickersAsync();

            // Assert
            Assert.NotNull(tickerResponse);
            Assert.NotEmpty(tickerResponse.Tickers);
        }

        #endregion Methods
    }
}
