//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            using (StreamReader readerList = new StreamReader("../../list.txt"))
            {
                List<string> list = new List<string>();
                string listItems = readerList.ReadLine();
                using (readerList)
                {
                    while (listItems != null)
                    {
                        list.Add(listItems);
                        listItems = readerList.ReadLine();
                    }
                }

                using (StreamReader reader = new StreamReader("../../Text.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("../../result.txt"))
                    {
                        string line = reader.ReadLine();
                        StringBuilder builder = new StringBuilder();

                        while (line != null)
                        {
                            builder.Append(line);
                            for (int i = 0; i < list.Count; i++)
                            {
                                builder = builder.Replace(list[i], "");
                            }
                            writer.WriteLine(builder);
                            builder.Clear();
                            line = reader.ReadLine();
                        }
                    }
                }
            }
        }
        catch(FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (OutOfMemoryException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
       
    }
}

