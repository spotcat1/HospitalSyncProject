

using Application.Contracts;
using Microsoft.Extensions.Caching.Memory;

namespace Infrastructure.Services
{
    public class CacheManagerSerivce : ICacheManagerService
    {
        private readonly IMemoryCache _cache;

        public CacheManagerSerivce(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<T> GetAsync<T>(string key, Func<Task<T>> func, int cachetime)
        {
            if (_cache.TryGetValue(key,out T value))
            {
                return value;
            }

            var Result = await func();
            Set(key, Result, cachetime);
            return Result;
        }

        public void Remove(string key)
        {
            _cache.Remove(key); 
        }

        public void Set(string key, object data, int cachetime)
        {
            if (data is not null)
            {
                _cache.Set(key,data,new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(cachetime)
                });
            }
        }
    }
}
