using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hash_table
{
    public class HashTable<T, K> : IEnumerable<KeyValuePair<K, T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] hashHolder;
        private const int StartCapacity = 16;
        private int capacity = StartCapacity;
        public int Count { get; private set; }

        public HashTable()
        {
            this.hashHolder = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.Count = 0;
        }

        public void Add(K key, T value)
        {
            if (this.Count >= this.capacity * 0.75)
            {
                this.capacity *= 2;
                var newHashHolder = this.hashHolder;
                hashHolder = new LinkedList<KeyValuePair<K, T>>[this.capacity];

                for (int i = 0; i < this.Count; i++)
                {
                    hashHolder[i] = newHashHolder[i];
                }
            }

            this.Count++;
            int index = GetIndex(key);
            if (this.hashHolder[index] == null)
            {
                this.hashHolder[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            var pair = new KeyValuePair<K, T>(key, value);
            this.hashHolder[index].AddLast(pair);
        }

        public T Find(K key)
        {
            int index = GetIndex(key);

            if (this.hashHolder[index] != null)
            {
                var currentItem = this.hashHolder[index].First;
                //Serach in the linked list here
                while (currentItem != null)
                {
                    if (currentItem.Value.Key.Equals(key))
                    {
                        return currentItem.Value.Value;
                    }

                    currentItem = currentItem.Next;
                }
            }

            throw new ArgumentException("No element found!");
        }

        public void Remove(K key)
        {
            var index = GetIndex(key);

            if (this.hashHolder[index] != null)
            {
                var currentItem = this.hashHolder[index].First;
                while (currentItem != null)
                {
                    if (currentItem.Value.Key.Equals(key))
                    {
                        this.hashHolder[index].Remove(currentItem);
                        this.Count--;
                    }

                    currentItem = currentItem.Next;
                }
            }
        }

        public void Clear()
        {
            this.capacity = StartCapacity;
            this.Count = 0;
            this.hashHolder = new LinkedList<KeyValuePair<K, T>>[this.capacity];
        }

        public T this[K key]
        {
            get
            {
                return this.Find(key);
            }

            set
            {
                this.Add(key, value);
            }
        }

        public List<K> Keys
        {
            get
            {
                List<K> keys = new List<K>();

                foreach (var item in this.hashHolder)
                {
                    if (item != null)
                    {
                        var currItem = item.First;
                        while (currItem != null)
                        {
                            keys.Add(currItem.Value.Key);
                            currItem = currItem.Next;
                        }
                    }
                }

                return keys;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.hashHolder)
            {
                if (list != null)
                {
                    foreach (var listItem in list)
                    {
                        yield return listItem;
                    }
                }
            }
        }

        private int GetIndex(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.capacity);
            return index;
        }

    }
}