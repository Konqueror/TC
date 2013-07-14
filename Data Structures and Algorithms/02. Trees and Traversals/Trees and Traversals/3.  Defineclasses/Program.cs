using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace Defineclasses
{
    class Program
    {
        static Folder C = new Folder("C");
        
        static void Main(string[] args)
        {

            string directory = @"C:\Store";
            DirSearch(directory, C);
            Console.WriteLine("The size of all files is : " + C.GetSize());
            Console.WriteLine(C);
        }

        private static void DirSearch(string directory, Folder currentFolder)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    Folder folder = new Folder(dir);
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        folder.Files.Add(new File(file, file.Length));
                    }

                    currentFolder.Folders.Add(folder);

                    DirSearch(dir, folder);
                }
            }
            catch (System.UnauthorizedAccessException excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
