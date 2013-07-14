using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Increasing_order
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter some numbers: ");

            string line = null;

            do
            {
                line = Console.ReadLine();
                if (line != string.Empty)
                {
                    numbers.Add(int.Parse(line));
                }
            }
            while (line != string.Empty);

            numbers.Sort();
            Console.WriteLine(string.Join(" -> ", numbers));
        }
    }
}
