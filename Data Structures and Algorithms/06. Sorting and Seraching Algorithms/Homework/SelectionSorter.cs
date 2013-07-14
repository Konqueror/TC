namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            //http://mattrank.net/wp-content/uploads/2012/01/selection-sort.gif
            //You are a slow!
            for (int i = 0; i < collection.Count - 1; i++)
	        {
		        int min = i;
                for (int j = i + 1; j < collection.Count; j++)
		        {
                    if (collection[j].CompareTo(collection[min]) < 0)
			        {
				        min = j;
			        }
		        }
                //slap
		        T temp = collection[i];
                collection[i] = collection[min];
                collection[min] = temp;
	        }
        }
    }
}
