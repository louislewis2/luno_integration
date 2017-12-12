namespace LunoIntegration.Test
{
    using System.Threading;
    using System.Threading.Tasks;

    using Xunit;

    public class LiveStreamTests : TestBase
    {
        [Fact]
        public async Task Can_Get_OrderBook_From_LiveStream()
        {
            // Arrange
            var pair = "XBTZAR";
            var client = this.GetClient();
            var cancellationTokenSource = new CancellationTokenSource();
            string receivedMessage = string.Empty;

            // Act
            await client.ConnectLive(pair: pair, orderBookReceivedAction: (string message) =>
            {
                receivedMessage = message;

                cancellationTokenSource.Cancel();

            }, orderUpdateReceivedAction: null, disconnectedAction: null, cancellationToken: cancellationTokenSource.Token);

            await client.DisconnectLive();
            WaitHandle.WaitAny(new[] { cancellationTokenSource.Token.WaitHandle });

            // Assert
            Assert.NotEqual(string.Empty, receivedMessage);
        }

        [Fact]
        public async Task Can_Get_OrderUpdate_From_LiveStream()
        {
            // Arrange
            var pair = "XBTZAR";
            var client = this.GetClient();
            var cancellationTokenSource = new CancellationTokenSource();
            string receivedMessage = string.Empty;

            // Act
            await client.ConnectLive(pair: pair, orderBookReceivedAction: null, orderUpdateReceivedAction: (string message) =>
            {
                receivedMessage = message;

                cancellationTokenSource.Cancel();

            }, disconnectedAction: null, cancellationToken: cancellationTokenSource.Token);

            await client.DisconnectLive();
            WaitHandle.WaitAny(new[] { cancellationTokenSource.Token.WaitHandle });

            // Assert
            Assert.NotEqual(string.Empty, receivedMessage);
        }
    }
}
