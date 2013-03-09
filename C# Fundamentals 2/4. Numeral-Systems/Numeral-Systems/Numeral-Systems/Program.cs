//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string strNum;
        int n;

        do
        {
            Console.Write("Enter a decimal intiger: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number

        Console.WriteLine(baseToBinary(n));
      
    }

    static string baseToBinary(int n)
    {

        string answer = String.Empty;

        do
        {
            answer = n % 2 + answer;
            n /= 2;

        } while (n != 0);

        return answer;
    }
}

