//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length-1; i++)
        {
            if (text[i] != text[i+1] )
            {
                Console.Write(text[i]);
            }
        }
        Console.Write(text[text.Length - 1]);
    }
}

