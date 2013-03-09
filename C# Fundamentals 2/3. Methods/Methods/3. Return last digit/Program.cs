//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(LastDigit(23));
    }
    static string LastDigit(int n)
    {
        int lastDigit = n % 10;
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        return digits[lastDigit];
    }
}

