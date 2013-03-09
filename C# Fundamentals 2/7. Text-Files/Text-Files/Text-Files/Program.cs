//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../Demo.txt");
        using (reader)
        {
            string line = reader.ReadLine();

            int lineNumber = 1;
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }

        }

    }
}

