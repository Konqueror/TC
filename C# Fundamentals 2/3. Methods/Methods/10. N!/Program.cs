//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<byte> tempList = new List<byte>(new byte[] { 1 });
        List<byte> resultList = new List<byte>();

        Console.WriteLine("100! is: ");

        for (int i = 1; i <= 100; i++)
        {
            resultList = (tempList = Multiply(tempList, i));
        }

        resultList.Reverse(); // Revers it to dislay the number in normal way
        // Display
        for (int i = 0; i < resultList.Count; i++)
        {
            Console.Write(resultList[i]);
        }

        Console.WriteLine();

    }

    static List<byte> AddArrays(List<byte> array1, List<byte> array2)
    {
        byte oneMore = 0;
        List<byte> list = new List<byte>();
        // logic
        for (int i = 0; i < Math.Max(array1.Count, array2.Count); i++)
        {
            if (i < array1.Count && i < array2.Count)
            {
                if (array1[i] + array2[i] + oneMore <= 9)
                {
                    list.Add((byte)(array1[i] + array2[i] + oneMore));
                    oneMore = 0;
                }
                else
                {
                    list.Add((byte)((array1[i] + array2[i] + oneMore) % 10));
                    oneMore = 1;
                }
            }
            else
            {
                if (i >= array1.Count)
                {
                    if (array2[i] + oneMore <= 9)
                    {
                        list.Add((byte)(array2[i] + oneMore));
                        oneMore = 0;
                    }
                    else
                    {
                        list.Add(0);
                        oneMore = 1;

                    }
                }
                if (i >= array2.Count)
                {
                    if (array1[i] + oneMore <= 9)
                    {
                        list.Add((byte)(array1[i] + oneMore));
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

    static List<byte> Multiply(List<byte> list, int y)
    {
        List<byte> result = new List<byte>();

        for (int i = 0; i < y; i++)
        {
            result = AddArrays(result, list);
        }

        return result;
    }
}

