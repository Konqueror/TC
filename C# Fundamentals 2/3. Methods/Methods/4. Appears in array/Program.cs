using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 5, 5 };
        Console.WriteLine("Thu number {0} appears {1} times in the array!", 5 ,Checker(array, 5));
    }

    static int Checker(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }

        return counter;
    }
}
