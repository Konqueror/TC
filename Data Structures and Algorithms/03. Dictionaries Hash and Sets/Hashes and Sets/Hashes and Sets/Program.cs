using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashes_and_Sets
{
    class Program
    {
        static void Main()
        {
            double[] givenArray = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            for (int i = 0; i < givenArray.Length; i++)
            {
                if(dictionary.ContainsKey(givenArray[i]))
                {
                    dictionary[givenArray[i]]++;
                }
                else
                {
                    dictionary.Add(givenArray[i], 1);
                }

            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
