namespace LunoIntegration.Test
{
    using System;
    using System.Threading.Tasks;

    using Xunit;

    using LunoIntegration.Enums;
    using LunoIntegration.Models;

    public class LimitOrderTests : TestBase
    {
        #region Methods

        [Fact]
        public async Task Can_Place_Limit_Order()
        {
            // Arrange
            var client = this.GetClient();
            var limitOrderCriteria = new LimitOrderCriteria
            {
                Pair = "XBTZAR",
                PostOnly = true,
                Price = 200000,
                Type = OrderTypes.Ask,
                Volume = 0.000006M
            };

            // Act
            var createOrderResponse = await client.PostLimitOrderAsync(limitOrderCriteria: limitOrderCriteria);

            // Assert
            Assert.NotNull(createOrderResponse);
            Assert.False(string.IsNullOrWhiteSpace(value: createOrderResponse.OrderId));
        }

        #endregion Methods
    }
}
