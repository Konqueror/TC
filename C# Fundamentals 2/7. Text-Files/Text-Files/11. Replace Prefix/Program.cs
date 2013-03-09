//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z,

using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("../../Result.txt", false);
        StreamReader reader = new StreamReader("../../Text.txt");
        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"(\b)test((\d|\w|_)*)(\b)", " ");
                    writer.WriteLine(Regex.Replace(line, @"(\s){2,}", " "));
                    line = reader.ReadLine();
                }
            }
        }
    }
}
