//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 8,2,3,7,6,5,4 };
        int[] sortedArray = SortArray(array, false);
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.WriteLine(sortedArray[i]);
        }

    }
    static int FindBiggestNumber(int[] array, int position)
    {
        int biggest = 0;
        for (int i = position; i < array.Length; i++)
        {
            if (array[i] > biggest)
            {
                biggest = array[i];
            }
        }
        return biggest;
    }

    static int[] SortArray(int[] array, bool increasing)
    {
        int temp, biggest; 
        for (int i = 0; i < array.Length; i++)
        {
            temp = array[i];
            biggest = FindBiggestNumber(array, i);
            array[Array.IndexOf(array, biggest)] = temp;
            array[i] = biggest;
        }

        if (increasing == true)
        {
            Array.Reverse(array);
        }

        return array;
    }
}
