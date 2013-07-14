using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    public class Queue<T>
    {
        readonly private LinkedList<T> elements = new LinkedList<T>();
        
        public int Count
        {
            get 
            { 
                return this.elements.Count; 
            }
        }

        public void Enqueue(T element)
        {
            this.elements.AddLast(element);
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return this.elements.First.Value;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            T element = this.elements.First.Value;
            this.elements.RemoveFirst();

            return element;
        }

        public override string ToString()
        {
            return string.Join(" -> ", this.elements);
        }
    }
}
