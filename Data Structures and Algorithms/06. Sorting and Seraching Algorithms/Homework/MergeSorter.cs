namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        IList<T> Merge(IList<T> collection)
        {

            if (collection.Count <= 1)
                return collection;

            int mid = collection.Count / 2;

            IList<T> left = new List<T>();
            IList<T> right = new List<T>();

            for (int i = 0; i < mid; i++)
                left.Add(collection[i]);

            for (int i = mid; i < collection.Count; i++)
                right.Add(collection[i]);

            return Merge(Merge(left), Merge(right));  

        }

        public IList<T> Merge(IList<T> left, IList<T> right)
        {
            IList<T> rv = new List<T>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (((IComparable)left[0]).CompareTo(right[0]) > 0)
                {
                    rv.Add(right[0]);
                    right.RemoveAt(0);
                }
                else
                {
                    rv.Add(left[0]);
                    left.RemoveAt(0);
                }
            }

            for (int i = 0; i < left.Count; i++)
            {
                rv.Add(left[i]);
            }
            
            for (int i = 0; i < right.Count; i++)
            {
                rv.Add(right[i]);
            }
            return rv;
        }  

        public void Sort(IList<T> collection)
        {
            Merge(collection);
        }
    }
}
