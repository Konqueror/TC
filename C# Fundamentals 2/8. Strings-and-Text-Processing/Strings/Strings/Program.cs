//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        char[] line = Console.ReadLine().ToCharArray();
        Array.Reverse(line);
        Console.Write("Reverced string: ");
        for (int i = 0; i < line.Length; i++)
        {
            Console.Write(line[i]);
        }
        Console.WriteLine();

    }
}

