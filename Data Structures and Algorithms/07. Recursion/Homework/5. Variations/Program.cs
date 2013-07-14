using System;
using System.Linq;

namespace _5.Variations
{
    class Program
    {
        private static int[] numbers;
        private static string[] set;

        static void Main(string[] args)
        {

            const int n = 3;
            int k = 2;
            set = new string[n] { "hi", "b", "a" };
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
                    Console.Write("{0} ", set[index]);
                }
                Console.WriteLine();
                return;
            }

            for (int i = startPoint; i <= endPoint; i++)
            {
                numbers[n] = i;
                Loop(n - 1, startPoint, endPoint);
            }
        }

    }
}
