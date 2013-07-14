using System;
using System.IO;

namespace _2.Traverse_the_directory
{
    public class CWindowsTraverse
    {
        static void Main(string[] args)
        {

            string directory = @"C:\WINDOWS";

            DirSearch(directory);
        }

        private static void DirSearch(string directory)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    foreach (string file in Directory.GetFiles(dir, "*.exe"))
                    {
                        Console.WriteLine(file);
                    }

                    DirSearch(dir);
                }
            }
            catch (System.UnauthorizedAccessException excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
