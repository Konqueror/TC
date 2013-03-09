//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string text = "This is text that have to be decoded";
        string key = "asd";
        string encodes = Encodes(text, key);
        Console.WriteLine(encodes);
        Console.WriteLine("Now lets decode this.");
        Console.WriteLine(Encodes(encodes, key));
    }
    static string Encodes(string str, string key)
    {
        char[] stringArray = str.ToCharArray();
        char[] keyArray = key.ToCharArray();

        StringBuilder coded = new StringBuilder();

        for (int i = 0, k = 0; i < stringArray.Length; i++, k++)
        {
            if (k == keyArray.Length - 1)
            {
                k = 0;
            }
            coded.Append((char)(stringArray[i] ^ keyArray[k]));

        }
        return coded.ToString();
    }
}

