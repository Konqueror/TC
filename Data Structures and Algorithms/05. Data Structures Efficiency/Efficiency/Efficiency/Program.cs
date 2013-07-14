using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Efficiency
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Tuple<string, string>>> students =
                new SortedDictionary<string, List<Tuple<string, string>>>();

            StreamReader reader = new StreamReader("../../students.txt");
            
            //Read file and load it to SortedDictionary
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] separated = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = separated[0].Trim();
                    string lastName = separated[1].Trim();
                    string course = separated[2].Trim();

                    if (students.ContainsKey(course))
                    {
                        students[course].Add(new Tuple<string, string>(firstName, lastName));
                    }
                    else
                    {
                        var studentsInCourse = new List<Tuple<string, string>>();
                        studentsInCourse.Add(new Tuple<string, string>(firstName, lastName));

                        students.Add(course, studentsInCourse);
                    }


                    line = reader.ReadLine();
                }
            }

            //Print the list  and sort it
            foreach (var item in students)
            {
                var sortedNames = item.Value;
                sortedNames.Sort();
                Console.Write(item.Key + ": ");

                foreach (var name in sortedNames)
                {
                    Console.Write("{0} {1}, ", name.Item1, name.Item2);
                }

                Console.WriteLine();
            }
        }

    }
}