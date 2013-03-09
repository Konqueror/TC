//Write a program that parses an URL address given in the format
//[protocol]://[server]/[resource]

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/20";

        Console.WriteLine("[protocol] " + Regex.Match(url, "[^:]*"));
        Console.WriteLine("[server]  " + Regex.Match(url, @"/([^/][\w\.]*)"));
        Console.WriteLine("[resource] " + Regex.Match(url, @"\b/[^/][\w.]*.+"));
    }
}

