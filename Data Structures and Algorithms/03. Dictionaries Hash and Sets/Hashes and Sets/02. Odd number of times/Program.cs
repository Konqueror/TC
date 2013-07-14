using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_number_of_times
{
    class Program
    {
        static void Main()
        {
            string[] givenArray = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (dictionary.ContainsKey(givenArray[i]))
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
                if(item.Value % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
