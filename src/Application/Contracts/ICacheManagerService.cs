

namespace Application.Contracts
{
    public interface ICacheManagerService
    {
        Task<T> GetAsync<T>(string key, Func<Task<T>> func, int cachetime);

        void Set(string key, object data, int cachetime);

        void Remove(string key);
        
    }
}
