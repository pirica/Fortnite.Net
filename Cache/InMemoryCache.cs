using System;
using System.Runtime.Caching;

namespace Fortnite.Net.Cache
{
    public sealed class InMemoryCache : ICacheService
    {

        internal readonly FortniteApi Api;

        public InMemoryCache(FortniteApi api)
        {
            Api = api;
        }
        
        public T Get<T>(string key) where T : class
        {
            return MemoryCache.Default.Get(key) as T;
        }

        public void Set(string key, object item)
        {
            if (item != null)
            {
                MemoryCache.Default.Add(key, item, DateTimeOffset.Now.AddSeconds(Api._cacheSeconds));
            }
        }
        
    }
}