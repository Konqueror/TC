//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.
﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Today is 29.01.2013 and yesterday was 28.01.2013 and this date does not exist 60.20.2033";

        DateTime date;
        foreach (Match item in Regex.Matches(text, @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(item);
        }
    }
}