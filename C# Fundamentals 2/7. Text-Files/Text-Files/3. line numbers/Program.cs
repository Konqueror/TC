//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../File1.txt");
        StreamWriter writer = new StreamWriter("../../File2.txt");
        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();

                int lineNumber = 1;
                while (line != null)
                {
                    writer.Write(lineNumber + ". ");
                    writer.WriteLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

