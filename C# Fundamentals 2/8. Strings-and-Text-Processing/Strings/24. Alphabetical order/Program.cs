//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        List<string> stringList = new List<string>(text.Split(' '));
        stringList.Sort();

        for (int i = 0; i < stringList.Count; i++)
        {
            Console.Write(stringList[i] + " ");
        }
    }
}
