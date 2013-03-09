// Write a program to convert binary numbers to their decimal representation.

using System;

class Program
{
    static void Main()
    {
        string binary = Console.ReadLine();

        Console.WriteLine(binaryToBase(binary));
    }

    static int binaryToBase(string binary)
    {

        int answer = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            answer = answer << 1;
            if (binary[i] == '1')
            {
                answer = answer ^ 1;
            }
        }

        return answer;
    }
}

