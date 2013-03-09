//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) 
//along with the day of week in Bulgarian.

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string str = "12.02.2013 22:30:00";

        DateTime date = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine("The day is {0} \n{1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}

