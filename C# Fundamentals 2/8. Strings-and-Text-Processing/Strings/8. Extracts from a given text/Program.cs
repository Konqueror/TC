//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        int counter = 0;
        foreach (Match sentence in Regex.Matches(text, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
        {
            counter++;
            Console.Write("Sentence {0}: ", counter);
            Console.WriteLine(sentence.Groups[1]);
        }
    }
}

