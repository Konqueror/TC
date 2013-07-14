namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            for (int left = 0, right = this.items.Count - 1; left <= right; )
            {
                int middle = left + ((right - left) >> 1);

                if (this.items[middle].CompareTo(item) < 0)
                    left = middle + 1;

                else if (this.items[middle].CompareTo(item) > 0)
                    right = middle - 1;

                else return true;
            }

            return false;
        }

        public void Shuffle()
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < items.Count; i++)
            {
                int randomNumber = randomGenerator.Next(items.Count);
                T tempItem = items[i];
                items[i] = items[randomNumber];
                items[randomNumber] = tempItem;

            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
