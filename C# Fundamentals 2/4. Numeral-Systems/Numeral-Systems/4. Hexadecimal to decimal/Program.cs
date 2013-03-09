// Write a program to convert hexadecimal numbers to their decimal representation
using System;

class Program
{
    static void Main()
    {
        string hex = Console.ReadLine();

        Console.WriteLine(hexadecimalToDecimal(hex));
    }
    static int hexadecimalToDecimal(string hex)
    {
        int result = 0;
        int length = hex.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            switch (hex[i])
            {
                case 'A':
                    result = result + 10 * (int)Math.Pow(16, length - 1 - i); 
                    break;
                case 'B':
                    result = result + 11 * (int)Math.Pow(16, length - 1 - i); 
                    break;
                case 'C':
                    result = result + 12 * (int)Math.Pow(16, length - 1 - i); 
                    break;
                case 'D':
                    result = result + 13 * (int)Math.Pow(16, length - 1 - i); 
                    break;
                case 'E':
                    result = result + 14 * (int)Math.Pow(16, length - 1 - i); 
                    break;
                case 'F':
                    result = result + 15 * (int)Math.Pow(16, length - 1 - i); 
                    break;
                default:
                    result = result + (hex[i] - '0') * (int)Math.Pow(16, length - 1 - i); 
                    break;
            }
        }
                    
        return result;
    }
}

