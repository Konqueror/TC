//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class Program

{
    static void Main()
    {
        string strNum;
        int a, b, c;
        do
        {
            Console.Write("Enter the first number: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out a));  // check if it is a real number

        do
        {
            Console.Write("Enter the second number: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out b));  // check if it is a real number

        do
        {
            Console.Write("Enter the third number: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out c));  // check if it is a real number

        Console.WriteLine(GetMax(GetMax(a,b), c));
    }
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

