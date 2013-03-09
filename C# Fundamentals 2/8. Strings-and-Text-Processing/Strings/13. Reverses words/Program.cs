//Write a program that reverses the words in given sentence.

using System;
using System.Text;
class Program
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        StringBuilder result = new StringBuilder();
        StringBuilder temp = new StringBuilder();
        string strTemp;
        for (int i = text.Length - 1; i >= 0; i--)
        {
            if (text[i] != ' ')
            {
                if (text[i] != '!' && text[i] != '?' && text[i] != '.')
                {
                    temp.Append(text[i]);
                }
            }
            else
            {
                strTemp = ReverseString(temp.ToString());
                result.Append(strTemp);
                result.Append(' ');
                temp.Clear();
            }
            if (i == 0)
            {
                strTemp = ReverseString(temp.ToString());
                result.Append(strTemp);
                result.Append(' ');
                temp.Clear();
            }
        }
        Console.WriteLine(result);
    }
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

