//Write a program to check if in a given expression the brackets are put correctly.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Give me an expression: ");
        string expression = Console.ReadLine();
        int starting = 0;
        int ending = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
                starting++;
            if (expression[i] == ')')
                ending++;
        }
        if(starting == ending)
            Console.WriteLine("Correct expression");
        else
            Console.WriteLine("Incorrect expression");
    }
}

