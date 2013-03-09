//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../Text.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter("../../Result.txt");
            using (writer)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"start", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
    }
}
