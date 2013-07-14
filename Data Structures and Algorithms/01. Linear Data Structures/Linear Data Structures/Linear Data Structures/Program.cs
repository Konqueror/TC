using System;
using System.Linq;
using System.Collections.Generic;

namespace Linear_Data_Structures
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

            int sum = numbers.Sum();
            double average = sum / numbers.Count;

            Console.WriteLine("The sum is: {0} and the average is {1}", sum, average);
        }
    }
}
