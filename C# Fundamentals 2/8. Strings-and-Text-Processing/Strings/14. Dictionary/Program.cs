//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Search for a word: ");
        string word = Console.ReadLine();
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
        };
        // TODO: Interpolation search
        foreach (string words in dictionary)
        {
            var fragments = Regex.Match(words, "(.*?) - (.*)").Groups;

            if (fragments[1].Value == word)
            {
                Console.WriteLine(fragments[2]);
                break;
            }
            else
            {
                Console.WriteLine("This word does not exist in the dictionary!");
                break;
            }
        }
    }
}

