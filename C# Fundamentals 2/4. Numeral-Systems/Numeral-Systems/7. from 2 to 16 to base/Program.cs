// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        string input = Console.ReadLine();
        Console.WriteLine("That number is in base: ");
        int from = int.Parse(Console.ReadLine());
        Console.WriteLine("We want to convert it to: ");
        int to = int.Parse(Console.ReadLine());

        ConvertToSelected(ConvertTo10(input, from), to);
    }
    static int ConvertTo10(string input, int from)
    {
        int answer = from * ToNumber(input[0]) + ToNumber(input[1]);

        for (int i = 2; i < input.Length; i++)
        {
            answer = answer * from + ToNumber(input[i]);
        }
        return answer;
    }

    static void ConvertToSelected(int octal, int to)
    {
        StringBuilder result = new StringBuilder();

        while (octal > 0)
        {
            int k = octal > to ? (octal % to) : octal;
            switch (k)
            {
                case 0: result.Append('0'); break;
                case 1: result.Append('1'); break;
                case 2: result.Append('2'); break;
                case 3: result.Append('3'); break;
                case 4: result.Append('4'); break;
                case 5: result.Append('5'); break;
                case 6: result.Append('6'); break;
                case 7: result.Append('7'); break;
                case 8: result.Append('8'); break;
                case 9: result.Append('9'); break;
                case 10: result.Append('A'); break;
                case 11: result.Append('B'); break;
                case 12: result.Append('C'); break;
                case 13: result.Append('D'); break;
                case 14: result.Append('E'); break;
                case 15: result.Append('F'); break;
            }
            octal = octal / to;
        }

        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]); // print the String builder reverced!
        }      
    }

    static int ToNumber(char number)
    {
        if (number == 'A')
            return 10;
        if (number == 'B')
            return 11;
        if (number == 'C')
            return 12;
        if (number == 'D')
            return 13;
        if (number == 'E')
            return 14;
        if (number == 'F')
            return 15;

        return int.Parse(number.ToString());
    }
}

