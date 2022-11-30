using System.Data.SqlClient;

namespace bricksnetcoreapi.Common
{
    public class SqlHelper
    {
        private readonly IConfiguration configuration;
        public SqlHelper(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public string GetConnectionString()
        {
            var connectionSttring = configuration.GetConnectionString("BricksdbConn").ToString();
            return connectionSttring;
        }
    }
}