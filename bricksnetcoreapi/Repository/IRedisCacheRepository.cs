namespace bricksnetcoreapi.Repository
{
    public interface IRedisCacheRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetData<T>(string key);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiredateTime"></param>
        /// <returns></returns>
        bool SetData<T>(string key, T value, DateTimeOffset expiredateTime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object RemoveData(string key);
    }
}
