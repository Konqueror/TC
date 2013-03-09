using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.IEnumerable
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> elements)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty element");
            }

            T sum = default(T);

            foreach (T item in elements)
            {
                sum = (dynamic)sum + item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> elements)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty element");
            }

            T product = (dynamic)1;

            foreach (T item in elements)
            {
                product = (dynamic)product * item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> elements)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty element");
            }

            T min = elements.First();

            foreach (T item in elements)
            {
                if (item < (dynamic)min)
                {
                    min = item;
                }
            }

            return min;
        }
        public static T Max<T>(this IEnumerable<T> elements)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty element");
            }

            T max = elements.First();

            foreach (T item in elements)
            {
                if (item > (dynamic)max)
                {
                    max = item;
                }
            }

            return max;
        }
        public static T Average<T>(this IEnumerable<T> elements)
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty element");
            }

            T average = (dynamic)0;

            foreach (T item in elements)
            {
                average = average + (dynamic)item;
            }

            return (dynamic)average / (elements.Count());
        }
    }
}
