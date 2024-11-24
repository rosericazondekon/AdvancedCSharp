using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class GenericCache<T>
{
    private readonly Dictionary<string, CacheItem<T>> _cache = new Dictionary<string, CacheItem<T>>();
    public void AddItem(string key, T value, TimeSpan expirationDuration){
        _cache[key] = new CacheItem<T>(value, expirationDuration);
    }
    public T GetItem(string key)
    {
        if(_cache.TryGetValue(key, out CacheItem<T> cacheitem))
        {
            if(cacheitem.isExpired()){
                _cache.Remove(key);
                throw new InvalidOperationException("Attempt to retrieve an expired item from the cache!");
            }
            return cacheitem.Value;
        }
        throw new KeyNotFoundException($"Item with key '{key}' not found in the cache.");
    }
    public void Display()
    {
        Console.WriteLine("Current items in the cache:");
        foreach(var keyValue in _cache)
        {
            Console.WriteLine($"Key: {keyValue.Key}, Expiration Time: {keyValue.Value.ExpirationTime}, Value: {keyValue.Value.Value}");
        }
    }
}