//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class Program
{
    static void Main()
    {
        string strNum;
        short number;

        do
        {
            Console.Write("Enter a 16-bit signed integer: ");
        }
        while (!short.TryParse(strNum = Console.ReadLine(), out number)); // check if it is a real number

        short sing = number;

        if (sing <= 0)
            number++; 

        for (int i = 15; i >= 0; i--)
        {
            short exponent = (short)Math.Pow(2, i);
            short digit = (short)(number / exponent);
            number = (short)(number % exponent);

            if (sing < 0)
                Console.Write(1 + digit);
            else
                Console.Write(digit);
        }

        Console.WriteLine();
    }
}

