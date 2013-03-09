using System;
using System.Collections.Generic;

namespace _02.IEnumerable
{
    class IO
    {
        public static void Main()
        {
            List<float> floatList = new List<float>();
            floatList.Add(2.2F);
            floatList.Add(2.2F);
            floatList.Add(2.2F);
            floatList.Add(2.2F);
            List<int> intList = new List<int>();
            intList.Add(2);
            intList.Add(242);
            intList.Add(3);
            intList.Add(24);

            Console.WriteLine(floatList.Sum<float>());
            Console.WriteLine(intList.Sum<int>());

            Console.WriteLine(floatList.Product<float>());
            Console.WriteLine(floatList.Min<float>());
            Console.WriteLine(floatList.Max<float>());
            Console.WriteLine(floatList.Average<float>());
        }
    }
}
