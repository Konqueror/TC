//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string hex = Console.ReadLine();

        Console.WriteLine(BinToHex(hex));
    }
    static StringBuilder BinToHex(string input)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length % 4; i++)
        {
            input = 0 + input; // and zeroes to make it % 4 = 0;
        }

        for (int i = 0; i < input.Length; i = i + 4)
        {
            if (input.Substring(i, 4) == "0000")
                result.Append(0);
            else if (input.Substring(i, 4) == "0001")
                result.Append(1);
            else if (input.Substring(i, 4) == "0010")
                result.Append(2);
            else if (input.Substring(i, 4) == "0011")
                result.Append(3);
            else if (input.Substring(i, 4) == "0100")
                result.Append(4);
            else if (input.Substring(i, 4) == "0101")
                result.Append(5);
            else if (input.Substring(i, 4) == "0110")
                result.Append(6);
            else if (input.Substring(i, 4) == "0111")
                result.Append(7);
            else if (input.Substring(i, 4) == "1000")
                result.Append(8);
            else if (input.Substring(i, 4) == "1001")
                result.Append(9);
            else if (input.Substring(i, 4) == "1010")
                result.Append('A');
            else if (input.Substring(i, 4) == "1011")
                result.Append('B');
            else if (input.Substring(i, 4) == "1100")
                result.Append('C');
            else if (input.Substring(i, 4) == "1101")
                result.Append('D');
            else if (input.Substring(i, 4) == "1110")
                result.Append('E');
            else if (input.Substring(i, 4) == "1111")
                result.Append('F');
        }
        return result;
    }
}

