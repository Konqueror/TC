using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        BinaryHeap<T> store = new BinaryHeap<T>();

        public int Count
        {
            get 
            {
                return this.store.Count; 
            }
        }

        public void Enqueue(T value)
        {
            this.store.Add(value);
        }

        public T Dequeue()
        {
            T result = this.store.Peek();
            this.store.Remove(result);

            return result;
        }
 
    }
}
