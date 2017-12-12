namespace LunoIntegration.Test
{
    using System;
    using System.Threading.Tasks;

    using Xunit;

    public class TradeTests : TestBase
    {
        #region Methods

        [Fact]
        public async Task Can_Get_Trades()
        {
            // Arrange
            var pair = "XBTZAR";
            var client = this.GetClient();

            // Act
            var tradeResponse = await client.GetTradesAsync(pair: pair);

            // Assert
            Assert.NotNull(tradeResponse);
            Assert.NotEmpty(tradeResponse.Trades);
        }

        [Fact]
        public async Task Can_Get_Past_Trades()
        {
            // Arrange
            var pair = "XBTZAR";
            var client = this.GetClient();
            var since = new DateTime(2016, 01, 01);

            // Act
            var tradeResponse = await client.GetTradesAsync(pair: pair, since: since);

            // Assert
            Assert.NotNull(tradeResponse);
            Assert.NotEmpty(tradeResponse.Trades);
        }

        #endregion Methods
    }
}
