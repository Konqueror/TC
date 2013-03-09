//Write a program that reads a string from the console and lists all different words in the string along with
//information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        var dictionary = new Dictionary<string, int>(); // use Dictionary for a first time ever. It is cool!

        foreach (Match word in Regex.Matches(text, @"\w+"))// split the text to words
        {
            dictionary[word.Value] = dictionary.ContainsKey(word.Value) ? dictionary[word.Value] + 1 : 1;
        }

        foreach (var elemetn in dictionary)
        {
            Console.WriteLine("{0}: {1} times", elemetn.Key, elemetn.Value);
        }
    }
}

