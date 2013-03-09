//Write a program, that reads from the console an array of N integers and an integer K
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class Program
{
    static void Main()
    {
        string strNum;
        int n;
        int result;
        do
        {
            Console.Write("Enter the length of the array:");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            do
        {
            Console.Write("Enter the {0}th element:", i);
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out array[i])); // check if it is a real number
        }

        int k;
        do
        {
            Console.Write("Enter K:");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out k)); // check if it is a real number

        Array.Sort(array); // Sort the array without making our algo.
        if (array[0] > k)
        {
            Console.WriteLine("There is no such a number that is smaller ot  equal to K.");
        }
        else
        {
            Console.Write("Position: ");
            int index = Array.BinarySearch(array, k);
            if (index >= 0)
            {
                Console.Write(index);
            }
            else
            {
                while (index < 0)
                {
                    if (k < array[0])
                    {
                        break;
                    }

                    k--;
                    index = Array.BinarySearch(array, k);
                }
                Console.Write(index);
            }
            Console.Write(" counting from zero.");
        }
    }
}
