using System.Collections.Generic;

namespace TestBot.Storage.Implementations
{
    public class InMemoryStorage : IDataStorage
    {
        private readonly Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        public T RestoreObject<T>(string key)
        {
            if (!_dictionary.ContainsKey(key)) throw new System.Exception            
        }

        public void StoreObject(object obj, string key)
        {
            if (_dictionary.ContainsKey(key)) return;
            _dictionary.Add(key, obj);
        }
    }
}
