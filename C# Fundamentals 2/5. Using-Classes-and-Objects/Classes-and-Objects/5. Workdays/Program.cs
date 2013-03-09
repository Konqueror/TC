//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class Program
{
    static void Main()
    {
        DateTime givenDate = new DateTime(2013, 4, 30);

        Console.WriteLine(Workdays(givenDate));
    }

    static int Workdays(DateTime givenDate)
    {
        DateTime[] Holidays = new[]
        {
           new DateTime(DateTime.Now.Year, 1, 1),
           new DateTime(DateTime.Now.Year, 3, 3),
           new DateTime(DateTime.Now.Year, 5, 1),
           new DateTime(DateTime.Now.Year, 5, 2),
           new DateTime(DateTime.Now.Year, 5, 6),
           new DateTime(DateTime.Now.Year, 5, 24),
           new DateTime(DateTime.Now.Year, 9, 22),
           new DateTime(DateTime.Now.Year, 12, 24),
           new DateTime(DateTime.Now.Year, 12, 25),
           new DateTime(DateTime.Now.Year, 12, 26),
           new DateTime(DateTime.Now.Year, 12, 31),
        };

        int days = 0;
        for (DateTime i = DateTime.Today; i < givenDate; i = i.AddDays(1))
        {
            if (i.DayOfWeek.ToString() != "Sunday" && i.DayOfWeek.ToString() != "Saturday" && Array.IndexOf(Holidays, i) == -1)
            {
                days++;
            }
        }
        return days;

    }
}

