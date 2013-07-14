using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int emptySpaces = 0;

            foreach (char letter in input)
            {
                if (letter == '*')
                {
                    emptySpaces++;
                }
            }
            BigInteger start = 1;
            Console.WriteLine(start << emptySpaces);
        }
    }
}
