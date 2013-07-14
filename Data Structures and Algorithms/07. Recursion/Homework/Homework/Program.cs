using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static int[] numbers;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number < 5");
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            Loops(n - 1, n);
        }

        public static void Loops(int n, int endPoint)
        {
            if (n < 0)
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
                return;
            }

            for (int i = 1; i <= endPoint; i++)
            {
                numbers[n] = i;
                Loops(n - 1, endPoint);
            }
        }
    }
}
