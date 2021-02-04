namespace Fortnite.Net.Cache
{
    public interface ICacheService
    {

        T Get<T>(string key) where T : class;
        void Set(string key, object item);

    }
}