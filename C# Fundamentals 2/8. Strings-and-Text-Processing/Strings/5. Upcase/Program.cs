//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", found => found.Groups[1].Value.ToUpper()));
    }
}

