using System;
using System.Collections;

namespace Module12
{
    /// <summary>
    /// Izh-12-6. Generics and Collections
    /// </summary>
    public class Set<T>
    {
        private T[] _set;
        public int Count { get; private set; }

        public Set()
        {
            _set = new T[] { };
            Count = 0;
        }

        public void Add(T data)
        {
            if (Array.Exists(_set, (elem) => elem.Equals(data))) return;
            Array.Resize(ref _set, Count + 1);
            _set[Count] = data;
            Count++;
        }

        public void Remove(T data)
        {
            if (Count == 0)
            {
                return;
            }

            var index = Array.IndexOf(_set, data);
            if (index < 0) return;

            if (Count == 1)
            {
                _set = new T[] { };
                Count = 0;
                return;
            }

            var temp = new T[Count - 1];
            Array.Copy(_set, temp, index);
            if (index < Count - 1)
            {
                Array.Copy(_set, index + 1, temp, index, Count - index - 1);
            }

            _set = temp;
            Count--;
        }

        public bool Contains(T data)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data.Equals(_set[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _set[i];
            }
        }
    }
}
