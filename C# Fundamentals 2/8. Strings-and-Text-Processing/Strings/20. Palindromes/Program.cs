//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class Program
{
    static void Main()
    {
        string text = "I have an exe file wich plays ABBA";
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if(CheckForPalindromes(words[i]) == true)
                Console.WriteLine(words[i]);
        }
    }
    static bool CheckForPalindromes(string text)
    {
        for (int i = 0; i <= text.Length  / 2 - 1; i++)
		{
            if (text[i] != text[(text.Length  / 2) - 1 - i])
            {
                return false;
            }
		}
        return true;
    }
}

