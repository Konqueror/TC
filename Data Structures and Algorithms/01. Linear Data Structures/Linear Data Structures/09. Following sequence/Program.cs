using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Following_sequence
{
    class Program
    {
        static void Main()
        {
            int n = 2;
            const int Length = 50;

            var results = new List<int>(4);
            var numbers = new Queue<int>();
            numbers.Enqueue(n);

            for (int i = 0; i < Length; i++)
            {
                int currentS = numbers.Dequeue();
                results.Add(currentS);
                //Look at the formula;
                numbers.Enqueue(currentS + 1);
                numbers.Enqueue(2 * currentS + 1);
                numbers.Enqueue(currentS + 2);
            }

            Console.WriteLine(string.Join(" -> ", results));
        }
    }
}
