//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings
using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        foreach (var symbol in input)
        {
            Console.WriteLine("\\u{0:X4}", (int)symbol);
        }
    }
}

