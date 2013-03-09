using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../Text.txt");
        using (reader)
        {
            string text = reader.ReadToEnd();
            string[] list = text.Split('\n');
            Array.Sort(list);
            StreamWriter writer = new StreamWriter("../../Result.txt");
            using (writer)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    writer.Write(list[i]);
                }
            }
        }

    }
}

