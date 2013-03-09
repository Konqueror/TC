//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../File1.txt");
        StreamWriter writer = new StreamWriter("../../ResultFile.txt");
        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();

                int lineNumber = 1;
                while (line != null)
                {
                    writer.WriteLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }

            StreamReader reader2 = new StreamReader("../../File2.txt");
            using (reader2)
            {
                string line = reader2.ReadLine();

                int lineNumber = 1;
                while (line != null)
                {
                    writer.WriteLine(line);
                    lineNumber++;
                    line = reader2.ReadLine();
                }
            }
        }
        Console.WriteLine("Wer are done!");
    }
}

