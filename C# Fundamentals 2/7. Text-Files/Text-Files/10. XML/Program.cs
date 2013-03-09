//Write a program that extracts from given XML file all the text without the tags. Example:

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../text.xml"))
        {
            int symbol = reader.Read();
            while (symbol != -1)
            {
                if (symbol == '>')
                {
                    StringBuilder element = new StringBuilder();
                    while (symbol != '<')
                    {
                        symbol = reader.Read();
                        element.Append((char)symbol);

                    }
                    element.Remove(element.Length-1, 1);
                    if(element.Length > 0)
                        Console.WriteLine(element);
                }
                symbol = reader.Read();
            }
        }
    }
}

