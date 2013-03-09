//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

using System;
using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder();
        do
        {
            builder.Clear();
            Console.Write("Enter a stirng (max 20 chars):");
            builder.Append(Console.ReadLine());

        } while (builder.Length > 20);
        // add *
        for (int i = builder.Length; i < 20; i++)
        {
            builder.Append("*");
        }
        Console.WriteLine(builder);
    }
}
