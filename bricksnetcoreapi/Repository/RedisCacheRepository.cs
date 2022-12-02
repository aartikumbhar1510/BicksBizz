using bricksnetcoreapi.Common;
using bricksnetcoreapi.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;

namespace bricksnetcoreapi.Repository
{
    public class RedisCacheRepository : IRedisCacheRepository
    {
        private IDatabase _db;

        public RedisCacheRepository()
        {
            ConfigureRedis();
        }

        private void ConfigureRedis() => _db = (IDatabase)ConnectionHelper.Connection.GetDatabase();
        public T GetData<T>(string key)
        {
            throw new NotImplementedException();
        }

        public object RemoveData(string key)
        {
            throw new NotImplementedException();
        }

        public bool SetData<T>(string key, T value, DateTimeOffset expiredateTime)
        {
            throw new NotImplementedException();
        }
    }
}
