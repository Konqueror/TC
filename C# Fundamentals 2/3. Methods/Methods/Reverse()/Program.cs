//Write a method that reverses the digits of given decimal number. Example: 256  652
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Reverse(12345));
    }

    static int Reverse(int n)
    {
        int result = 0;
        while (n != 0)
        {
            result = result + n % 10;
            n = n / 10;
            result = result * 10;
        }
        result = result / 10;

        return result;
    }
}

