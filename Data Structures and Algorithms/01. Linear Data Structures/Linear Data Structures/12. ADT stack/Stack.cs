using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_stack
{
    public class Stack<T>
    {
        int count = 0;
        T[] array;
        int capacity;

        public Stack(int capacity)
        {
            this.capacity = capacity;
            this.array = new T[capacity];
        }

        public void Push(T value)
        {
            if (this.count == this.capacity)
            {
                this.DoubleSize();
            }

            this.array[this.count] = value;
            count++;
        }

        public T Pop()
        {

            if (this.count > 0)
            {
                this.count--;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return array[this.count];
        }

        private void DoubleSize()
        {
            T[] newArray = new T[this.capacity * 2];
            
            for (int i = 0; i < this.capacity; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
            this.capacity *= 2;
        }
    }
}
