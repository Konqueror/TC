//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        sbyte[] array1 = { 1,1};
        sbyte[] array2 = { 9,9,9, 9,8};

        List<int> result = AddArrays(array1, array2);

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
    static List<int> AddArrays(sbyte[] array1, sbyte[] array2)
    {
        byte oneMore = 0;
        List<int> list = new List<int>();
        // logic
        for (int i = 0; i < Math.Max(array1.Length, array2.Length); i++)
        {
            if (i < array1.Length && i < array2.Length)
            {
                if (array1[i] + array2[i] + oneMore <= 9)
                {
                    list.Add(array1[i] + array2[i] + oneMore);
                    oneMore = 0;
                }
                else
                {
                    list.Add((array1[i] + array2[i] + oneMore) % 10);
                    oneMore = 1;
                }
            }
            else
            {
                if (i >= array1.Length)
                {
                    if (array2[i] + oneMore <= 9)
                    {
                        list.Add(array2[i] + oneMore);
                        oneMore = 0;
                    }
                    else
                    {
                        list.Add(0);
                        oneMore = 1;

                    }
                }
                if (i >= array2.Length)
                {
                    if (array1[i] + oneMore <= 9)
                    {
                        list.Add(array1[i] + oneMore);
                        oneMore = 0;
                    }
                    else
                    {
                        list.Add(0);
                        oneMore = 1;

                    }
                }

            }
           
        }
        // check the last
        if (oneMore == 1)
        {
            list.Add(1);
        }
        return list;
    }
}

