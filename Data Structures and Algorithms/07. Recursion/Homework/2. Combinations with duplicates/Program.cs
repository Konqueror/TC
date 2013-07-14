using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Combinations_with_duplicates
{
    class Program
    {
        static int[] numbers;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());

            numbers = new int[k];
            Loops(k - 1, 1, n);
        }

        public static void Loops(int n, int startPoint, int endPoint)
        {
            if (n < 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
                return;
            }

            for (int i = startPoint; i <= endPoint; i++)
            {
                numbers[n] = i;
                Loops(n - 1, startPoint, endPoint);
                startPoint++;
            }
        }

    }
}
