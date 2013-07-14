using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            bool[] used = new bool[n];
            int[] array = new int[n];

            Permutation(0, n, array, used);
        }

        static void Permutation(int index, int n, int[] array, bool[] used)
        {
            if (index >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", array[i] + 1);
                }
                Console.WriteLine();
                return;
            }

            for (int k = 0; k < n; k++)
            {
                if (!used[k])
                {
                    used[k] = true;
                    array[index] = k;
                    Permutation(index + 1, n, array, used);
                    used[k] = false;
                }
            }
        }
    }
}
