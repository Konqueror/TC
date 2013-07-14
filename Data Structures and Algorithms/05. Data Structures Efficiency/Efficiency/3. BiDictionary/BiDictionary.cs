using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BiDictionary
{
    public class BiDictionary<TKey1, TKey2, TValue>
    {
        private Dictionary<TKey1, TValue> firstDictionary;
        private Dictionary<TKey2, TValue> secondDictionary;

        public int Count { get; set; }

        public BiDictionary()
        {
            this.firstDictionary = new Dictionary<TKey1, TValue>();
            this.secondDictionary = new Dictionary<TKey2, TValue>();
            this.Count = 0;
        }

        public void Add(TKey1 firstKey, TKey2 secondKey, TValue value)
        {
            this.firstDictionary.Add(firstKey, value);
            this.secondDictionary.Add(secondKey, value);
            this.Count++;
        }

        public void Remove(TKey1 firstKey, TKey2 secondKey, TValue value)
        {
            this.firstDictionary.Remove(firstKey);
            this.secondDictionary.Remove(secondKey);
            this.Count--;
        }

        public TValue Find(TKey1 firstKey)
        {
            if (this.firstDictionary.ContainsKey(firstKey))
            {
                return firstDictionary[firstKey];
            }

            throw new KeyNotFoundException("Key not Found");
        }

        public TValue Find(TKey2 secondKey)
        {
            if (this.secondDictionary.ContainsKey(secondKey))
            {
                return secondDictionary[secondKey];
            }

            throw new KeyNotFoundException("Key not Found");
        }


        public TValue Find(TKey1 firstKey, TKey2 secondKey)
        {
            if (this.firstDictionary.ContainsKey(firstKey) &&
                this.secondDictionary.ContainsKey(secondKey))
            {
                return secondDictionary[secondKey];
            }

            throw new KeyNotFoundException("Key not Found");
        }


    }
}
