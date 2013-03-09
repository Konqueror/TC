//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The maximum is: " + Max(1.2, 2.22, 3, 4));
        Console.WriteLine("The minimum is: " + Min(1, 2, 3.2222, 4));
        Console.WriteLine("The average is: " + Average(1, 2, -332.32322323, 4));
        Console.WriteLine("The sum is: " + Sum(1, 2, 3, 4));
        Console.WriteLine("The product is: " + Product(1, 2, 3, 4));

    }

    static T Max<T>(params T[] arr)
    {
        dynamic biggestNum = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > biggestNum)
                biggestNum = arr[i];
        }
        return biggestNum;
    }

    static T Min<T>(params T[] arr)
    {
        dynamic smallestNum = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < smallestNum)
                smallestNum = arr[i];
        }
        return smallestNum;
    }

    static T Average<T>(params T[] arr)
    {
        dynamic sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
        }
        return sum / arr.Length;
    }

    static T Sum<T>(params T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
        }
        return sum;
    }

    static T Product<T>(params T[] arr)
    {
        dynamic product = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            product = product * arr[i];
        }

        return product;
    }
}

