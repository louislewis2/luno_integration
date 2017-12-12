namespace LunoIntegration.Test
{
    using System.Threading.Tasks;

    using Xunit;

    public class OrderBookTests : TestBase
    {
        #region Methods

        [Fact]
        public async Task Can_Get_Btc_Zar_OrderBook()
        {
            // Arrange
            var pair = "XBTZAR";
            var client = this.GetClient();

            // Act
            var orderBook = await client.GetOrderBookAsync(pair: pair);

            // Assert
            Assert.NotNull(orderBook);
        }

        #endregion Methods
    }
}
