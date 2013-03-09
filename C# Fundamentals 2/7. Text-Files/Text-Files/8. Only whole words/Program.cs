//Modify the solution of the previous problem to replace only whole words (not substrings).

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
