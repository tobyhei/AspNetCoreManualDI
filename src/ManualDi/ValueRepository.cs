using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace ManualDi
{
    public class ValueRepository : IValueRepository
    {
        private readonly ConcurrentDictionary<int, ValueRecord> dictionary;

        public ValueRepository()
        {
            var dictionary = new Dictionary<int, ValueRecord>
            {
                { 1, new ValueRecord(1, "Test value 1") },
                { 2, new ValueRecord(2, "Test value 2") },
                { 3, new ValueRecord(3, "Test value 3") },
                { 4, new ValueRecord(4, "Test value 4") }
            };

            this.dictionary = new ConcurrentDictionary<int, ValueRecord>(dictionary);
        }

        public void Delete(int id) => dictionary.TryRemove(id, out _);
        public ValueRecord[] Get() => dictionary.Values.ToArray();
        public ValueRecord Get(int id) => dictionary.TryGetValue(id, out var val) ? val : default;
        public void Update(int id, ValueRecord value) => dictionary.AddOrUpdate(id, value, (_,__) => value);
    }
}
