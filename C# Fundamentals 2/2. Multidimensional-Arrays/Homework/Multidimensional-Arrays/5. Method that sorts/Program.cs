//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class Program
{
    static void Main()
    {
        string[] array = { "a", "abc", "ab", "abcde", "abcd" };
        string[] newArray = MySort(array);

        // Show the newArray!
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }

    static string[] MySort(string[] array)
    {
        string temp;
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i].Length > array[j].Length)
                {
                    // change their positions
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
}
