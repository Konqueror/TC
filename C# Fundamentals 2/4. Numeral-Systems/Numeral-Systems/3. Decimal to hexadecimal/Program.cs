//Write a program to convert decimal numbers to their hexadecimal representation.
using System;

class Program
{
    static void Main()
    {
        int n;
        string strNum;
        do
        {
            Console.Write("Enter a decimal intiger: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number

        Console.WriteLine(baseToHexadecimal(n));
    }

    static string baseToHexadecimal(int n)
    {
        string hex = String.Empty;
        while (n != 0)
        {
            if (n % 16 > 9)
            {
                hex = hex + (char)(n % 16 + 55); // Look at the ascii table :)
            }
            else
            {
                hex = Convert.ToString(n % 16) + hex;
            }
            n /= 16;
        }
        return hex;
    }
}

