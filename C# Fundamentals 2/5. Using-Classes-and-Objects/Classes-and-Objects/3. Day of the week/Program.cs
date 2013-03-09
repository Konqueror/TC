//Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Hello, what a nice, ");
        Console.WriteLine(DateTime.Today.DayOfWeek);
    }
}
