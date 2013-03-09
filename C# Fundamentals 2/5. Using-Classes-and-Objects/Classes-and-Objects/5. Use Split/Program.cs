//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

using System;

class Program
{
    static void Main()
    {
        string input= "43 68 9 23 318";
        Console.WriteLine(Sum(input));
    }
    static int Sum(string input)
    {
        int sum = 0;
        string[] numbers = input.Split(' ');
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + int.Parse(numbers[i]);
        }

        return sum;
    }
}

