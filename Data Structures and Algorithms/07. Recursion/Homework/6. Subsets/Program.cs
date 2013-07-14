using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Subsets
{
    class Program
    {
        private static int[] numbers;
        private static string[] set;

        public static void Main()
        {
            const int n = 3;
            set = new string[n] { "test", "rock", "fun" };
            int k = 2;
            numbers = new int[k];
            Loop(k - 1, 1, n);
        }

        public static void Loop(int n, int startPoint, int endPoint)
        {
            if (n < 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int index = numbers[i] - 1;
                    Console.Write(set[index] + " ");
                }
                Console.WriteLine();
                return;
            }

            for (int i = startPoint; i <= endPoint; i++)
            {
                numbers[n] = i;
                Loop(n - 1, startPoint + 1, endPoint);
                startPoint++;
            }
        }
    }
}
