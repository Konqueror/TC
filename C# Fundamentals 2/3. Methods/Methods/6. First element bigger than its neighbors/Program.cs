//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine(CheckTheFirst(array));

    }

    static int CheckTheFirst(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (BiggerThanNeighbors(array, i) == true)
            {
                return i;
            }
        }
        return -1;
    }

    static bool BiggerThanNeighbors(int[] array, int position)
    {
        if (position != 0 && position != array.Length - 1 && array[position] > array[position + 1] && array[position] > array[position - 1])
        {
            return true;  // It have 2 neighbords
        }
        else if (position == 0 && array[position] > array[position + 1])
        {
            return true;  // It have only one (it is first)
        }
        else if (position == array.Length - 1 && array[position] > array[position - 1])
        {
            return true; // It have only one (it is last)
        }

        return false;
    }
}