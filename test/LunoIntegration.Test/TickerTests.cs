namespace LunoIntegration.Test
{
    using System.Threading.Tasks;

    using Xunit;

    public class TickerTests : TestBase
    {
        #region Methods

        [Fact]
        public async Task Can_Get_Btc_Zar_Ticker()
        {
            // Arrange
            var pair = "XBTZAR";
            var client = this.GetClient();

            // Act
            var ticker = await client.GetTickerAsync(pair: pair);

            // Assert
            Assert.NotNull(ticker);
            Assert.Equal(pair, ticker.Pair);
        }

        #endregion Methods
    }
}
