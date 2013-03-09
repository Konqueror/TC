using System;
using System.IO;

class Program
{
    static void Main()
    {
        string line;

        StreamReader reader = new StreamReader(@"..\..\index.html");
        using (reader)
        {
            bool tag = false;
            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '<')
                    {
                        tag = true;
                    }

                    if (tag == false)
                    {
                        Console.Write(line[i]);
                    }
                    if (line[i] == '>')
                    {
                        tag = false;
                    }
                }
                if (tag == false)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

