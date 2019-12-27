
using System.Collections.Generic;

namespace Module12
{
    public class TreeData<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public TreeData(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
