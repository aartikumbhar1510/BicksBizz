using StackExchange.Redis;

namespace bricksnetcoreapi.Common
{
    public class ConnectionHelper
    {
        private static Lazy<ConnectionMultiplexer> lazyConnection;

        static ConnectionHelper() {
            ConnectionHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect(ConfigurationManager.AppSetting["RedisURL"]);
            });
        }

        public static ConnectionMultiplexer Connection { get { return ConnectionHelper.lazyConnection.Value; } }
    }
}
