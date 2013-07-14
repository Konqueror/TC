using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class BinaryHeap<T> : ICollection<T> where T : IComparable<T>
    {
        private const int DefaultSize = 10;

        private T[] data = new T[DefaultSize];
        private int count = 0;
        private int capacuty = DefaultSize;
        private bool sorted;

        public int Count
        {
            get 
            { 
                return count;
            }
        }

        public int Capacity
        {
            get 
            { 
                return capacuty; 
            }
            private set
            {
                int previousCapacity = capacuty;
                this.capacuty = Math.Max(value, count);
                if (capacuty != previousCapacity)
                {
                    T[] temp = new T[capacuty];
                    Array.Copy(this.data, temp, this.count);
                    this.data = temp;
                }
            }
        }
        
        public BinaryHeap()
        {
        }
        
        private BinaryHeap(T[] data, int count)
        {
            this.Capacity = count;
            Array.Copy(data, data, count);
        }

        public T Peek()
        {
            return this.data[0];
        }


        public void Clear()
        {
            this.count = 0;
            this.data = new T[capacuty];
        }

        public void Add(T item)
        {
            if (this.count == this.capacuty)
            {
                this.Capacity *= 2;
            }
            this.data[this.count] = item;
            this.UpHeap();
            this.count++;
        }

        public T Remove()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Cannot remove item, heap is empty.");
            }
            
            T v = data[0];
            this.count--;
            this.data[0] = data[count];
            this.data[count] = default(T); //Clears the Last Node
            this.DownHeap();
            return v;
        }

        private void UpHeap()
        //helper function that performs up-heap bubbling
        {
            this.sorted = false;
            int p = count;
            T item = data[p];
            int par = Parent(p);
            while (par > -1 && item.CompareTo(data[par]) < 0)
            {
                data[p] = data[par]; //Swap nodes
                p = par;
                par = Parent(p);
            }
            data[p] = item;
        }

        private void DownHeap()
        //helper function that performs down-heap bubbling
        {
            this.sorted = false;
            int n;
            int p = 0;
            T item = data[p];
            while (true)
            {
                int ch1 = Child1(p);
                if (ch1 >= count) break;
                int ch2 = Child2(p);
                if (ch2 >= count)
                {
                    n = ch1;
                }
                else
                {
                    n = data[ch1].CompareTo(data[ch2]) < 0 ? ch1 : ch2;
                }

                if (item.CompareTo(data[n]) > 0)
                {
                    this.data[p] = this.data[n]; //Swap nodes
                    p = n;
                }
                else
                {
                    break;
                }
            }
            this.data[p] = item;
        }

        private void EnsureSort()
        {
            if (!this.sorted)
            {
                Array.Sort(this.data, 0, this.count);
                this.sorted = true;
            }
        }

        private static int Parent(int index)
        {
            return (index - 1) >> 1;
        }

        private static int Child1(int index)
        {
            return (index << 1) + 1;
        }

        private static int Child2(int index)
        {
            return (index << 1) + 2;
        }

        public BinaryHeap<T> Copy()
        {
            return new BinaryHeap<T>(data, count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            EnsureSort();
            for (int i = 0; i < count; i++)
            {
                yield return data[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Contains(T item)
        {
            this.EnsureSort();
            
            if (Array.BinarySearch<T>(data, 0, count, item) >= 0)
            {
                return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.EnsureSort();
            Array.Copy(this.data, array, this.count);
        }

        public bool IsReadOnly
        {
            get 
            { 
                return false; 
            }
        }

        public bool Remove(T item)
        {
            this.EnsureSort();
            int itemPosition = Array.BinarySearch<T>(data, 0, count, item);

            if (itemPosition < 0)
            {
                return false;
            }
            else
            {
                Array.Copy(data, itemPosition + 1, data, itemPosition, count - itemPosition);

                this.data[count] = default(T);
                this.count--;
                return true;
            }
        }
    }
}
