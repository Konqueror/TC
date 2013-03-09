//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1,2,3,8,5,6 };

        Console.WriteLine(BiggerThanNeighbors(array, 3));

    }
    static bool BiggerThanNeighbors(int[] array, int position)
    {
        if (position != 0  && position != array.Length - 1 && array[position] > array[position + 1] && array[position] > array[position - 1] )
        {
            return true;  // It have 2 neighbords
        }
        else if (position == 0 && array[position] > array[position + 1])
        {
            return true;  // It have only one (it is first)
        }
        else if (position == array.Length - 1  && array[position] > array[position - 1])
        {
            return true; // It have only one (it is last)
        }

        return false;
    }
}

