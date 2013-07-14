namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void QSort(IList<T> collection, int left, int right)
        {
            int i = left, j = right;
            T pivot = collection[(left + right) / 2];

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    T tmp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QSort(collection, left, j);
            }

            if (i < right)
            {
                QSort(collection, i, right);
            }

        }

        public void Sort(IList<T> collection)
        {
            QSort(collection, 0, collection.Count - 1);
        }
    }
}
