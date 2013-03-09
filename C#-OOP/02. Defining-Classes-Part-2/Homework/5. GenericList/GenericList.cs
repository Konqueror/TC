using System;
using System.Text;
namespace Lib
{
    class GenericList<T>
    {
        private T[] elements;
        private int count = 0;

        // Constructor
        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }
        // You can construct list with no capacity so the capacity will be 1
        public GenericList()
            : this(1)
        {

        }
        // You cant change the count and capacity of the list
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }
        // Functions
        public void Add(T element)
        {
            if (count == Capacity)
            {
                DoubleCapacity();
            }
            this.elements[count] = element;
            count++;
        }
        // List: a, b, c, d. Remove c. Result: a, b, d, d and count--;
        public void Remove(int index)
        {
            if (index > count)
            {
                throw new IndexOutOfRangeException(String.Format("No element with index: {0}", index));
            }
            for (int i = index; i < count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            count--;

        }
        // Array: a, b, c, d, e. Insert f in position 3. Result: a, b, f, c, d, e
        public void Insert(T element, int index)
        {
            if (index > count)
            {
                throw new IndexOutOfRangeException(String.Format("No element with index: {0}", index));
            }
            if (count == Capacity)
            {
                DoubleCapacity();
            }
            for (int i = count; i >= index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            elements[index - 1] = element;
            count++;
        }
        public int IndexOf(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            this.elements = new T[1];
            count = 0;
        }

        // Double the capacity of the array
        private void DoubleCapacity()
        {
            T[] doubleElements = new T[2 * Capacity];

            for (int i = 0; i < count; i++)
            {
                doubleElements[i] = elements[i];
            }

            elements = doubleElements;
        }
        // Access elements by id
        public T this[int index]
        {
            get
            {
                T result = elements[index];
                return result;
            }
        }
        // ToString function with debugMode wich shows Capacity and count if it is in debug mode
        public string ToString(bool debugMode)
        {
            StringBuilder result = new StringBuilder();
            if (debugMode == true)
            {
                result.Append("Capacity: ").Append(Capacity).Append("\nCount: ").Append(Count).Append("\n");
            }

            for (int i = 0; i < count; i++)
            {
                result.Append(elements[i]);
                if (i < count - 1)
                {
                    result.Append("\n=====\n");
                }
            }

            return string.Format(result.ToString());
        }
        //7 Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
        //You may need to add a generic constraints for the type T.

        public T Min()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty");
            }
            else if (Count == 1) return elements[0];

            else if (elements[0] is IComparable<T>)
            {
                T min = elements[0];
                for (int i = 0; i < Count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(elements[i]) > 0)
                    {
                        min = elements[i];
                    }
                }
                return min;
            }
            else throw new TypeAccessException("The list is non-comparable");
        }
        public T Max()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty");
            }
            else if (Count == 1) return elements[0];

            else if (elements[0] is IComparable<T>)
            {
                T max = elements[0];
                for (int i = 0; i < Count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(elements[i]) < 0)
                    {
                        max = elements[i];
                    }
                }
                return max;
            }
            else throw new TypeAccessException("The list is non-comparable");
        }
    }
}
