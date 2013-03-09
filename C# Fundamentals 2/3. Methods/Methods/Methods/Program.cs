//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.

using System;

class Program
{
    static void Main()
    {
        GetName();
    }
    static void GetName()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}", name);
    }
}
