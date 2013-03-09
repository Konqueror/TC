//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;

class Program
{
    static void Main()
    {
       using (StreamReader reader = new StreamReader("../../text.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../temp.txt"))
            {
                string line = reader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                            writer.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    counter ++;
                }
            }
        }
        File.Copy("../../temp.txt", "../../text.txt", true);
        File.Delete("../../temp.txt");
                
    }
}

