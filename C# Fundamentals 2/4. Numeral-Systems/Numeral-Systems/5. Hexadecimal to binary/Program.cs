//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string hex = Console.ReadLine();
        Console.WriteLine(HexToBin(hex));
    }
    static StringBuilder HexToBin(string input)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input.Substring(i, 1) == "0")
                result.Append("0000");
            if (input.Substring(i, 1) == "1")
                result.Append("0001");
            if (input.Substring(i, 1) == "2")
                result.Append("0010");
            if (input.Substring(i, 1) == "3")
                result.Append("0011");
            if (input.Substring(i, 1) == "4")
                result.Append("0100");
            if (input.Substring(i, 1) == "5")
                result.Append("0101");
            if (input.Substring(i, 1) == "6")
                result.Append("0110");
            if (input.Substring(i, 1) == "7")
                result.Append("0111");
            if (input.Substring(i, 1) == "8")
                result.Append("1000");
            if (input.Substring(i, 1) == "9")
                result.Append("1001");
            if (input.Substring(i, 1) == "A")
                result.Append("1010");
            if (input.Substring(i, 1) == "B")
                result.Append("1011");
            if (input.Substring(i, 1) == "C")
                result.Append("1100");
            if (input.Substring(i, 1) == "D")
                result.Append("1101");
            if (input.Substring(i, 1) == "E")
                result.Append("1110");
            if (input.Substring(i, 1) == "F")
                result.Append("1111");
        }
        return result;
    }
}

