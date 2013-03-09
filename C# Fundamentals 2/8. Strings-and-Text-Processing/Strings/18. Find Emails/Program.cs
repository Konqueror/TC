//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string str = "My email is asd@abv.bg and i have a gmail account it is asd@gmail.com";

        foreach (var item in Regex.Matches(str, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}

