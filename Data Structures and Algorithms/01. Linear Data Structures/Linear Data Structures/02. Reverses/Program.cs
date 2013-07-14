using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverses
{
    class Program
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            Console.WriteLine("Enter some numbers: ");

            string line = null;

            do
            {
                line = Console.ReadLine();
                if (line != string.Empty)
                {
                    numbers.Push(int.Parse(line));
                }
            }
            while (line != string.Empty);

            Console.WriteLine(string.Join(" -> ", numbers));
        }
    }
}
