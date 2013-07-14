using System;
using System.Linq;
using System.IO;
using Wintellect.PowerCollections;

namespace PhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDictionary<Tuple<string, string>, string> phoneBook = new MultiDictionary<Tuple<string, string>, string>(true);
            FillPhones("../../phones.txt", phoneBook);
            ReadCommands("../../commands.txt", phoneBook);


        }

        static void FillPhones(string fileLocation, MultiDictionary<Tuple<string, string>, string> phoneBook)
        {
            StreamReader sr = new StreamReader(fileLocation);

            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    string text = sr.ReadLine();
                    string[] entryData = text.Split('|');

                    string names = entryData[0].Trim();
                    string city = entryData[1].Trim();
                    string number = entryData[2].Trim();

                    phoneBook.Add(new Tuple<string, string>(names, city), number);
                }

            }
        }

        static void ReadCommands(string fileLocation, MultiDictionary<Tuple<string, string>, string> phoneBook)
        {
            StreamReader sr = new StreamReader(fileLocation);

            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    string text = sr.ReadLine();
                    string entryData = text.Split('(', ')')[1];
                    string[] nameAndCity = entryData.Split(',');
                    //If there is city specified
                    if (nameAndCity.Length > 1)
                    {
                        Console.WriteLine("Select by name and city: ");
                        var filterdPeople = phoneBook.FindAll(key => key.Key.Item1 == nameAndCity[0] && key.Key.Item2 == nameAndCity[1]);
                        foreach (var people in filterdPeople)
                        {
                            Console.WriteLine(people);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Select only by name: ");
                        var filterdPeople = phoneBook.FindAll(key => key.Key.Item1 == nameAndCity[0]);
                        
                        foreach (var people in filterdPeople)
                        {
                            Console.Write(people.Key);
                            Console.WriteLine(" " + people.Value);
                        }
                    }
                }

            }
        }
    }
}
