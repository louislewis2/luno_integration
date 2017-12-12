namespace LunoIntegration.Test
{
    public class TestBase
    {
        #region Fields

        private const string key = "";
        private const string secret = "";

        #endregion Fields

        #region Methods

        public LunoClient GetClient()
        {
            return new LunoClient(key: key, secret: secret);
        }

        #endregion Methods
    }
}
