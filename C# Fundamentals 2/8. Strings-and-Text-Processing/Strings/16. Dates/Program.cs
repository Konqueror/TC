//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("day.month.year");
        Console.Write("Enter the first date: ");
        DateTime first = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        DateTime second = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine((first - second).TotalDays);
    }
}

