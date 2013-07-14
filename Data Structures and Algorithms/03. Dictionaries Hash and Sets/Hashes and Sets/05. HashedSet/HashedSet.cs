using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hash_table;

namespace _05.HashedSet
{
    class HashedSet<T>
    {
        HashTable<T, int> hashTable;

        public HashedSet()
        {
            hashTable = new HashTable<T, int>();
        }

        public void Add(T value)
        {
            hashTable.Add(value.GetHashCode(), value);
        }

        public T Find(T value)
        {
            return hashTable.Find(value.GetHashCode());
        }

        public void Remove(T value)
        {
            hashTable.Remove(value.GetHashCode());
        }

        public int Count
        {
            get
            {
                return hashTable.Count;
            }
        }

        public T this[T index]
        {
            get
            {
                return hashTable[index.GetHashCode()];
            }
            set
            {
                hashTable[index.GetHashCode()] = value;
            }
        }

    }
}
