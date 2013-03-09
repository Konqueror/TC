//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
//Sample HTML fragment
using System;

class Program
{
    static void Main()
    {
        string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        
        string result = html.Replace(@"<a href=""", "[URL=");
        result = result.Replace(@"</a>", "[/URL]");
        result = result.Replace(@""">", "]");
        Console.WriteLine(result);
    }
}

