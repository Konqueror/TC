using System;
using System.Linq;

namespace _3.BiDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            BiDictionary<string, int, string> biDictionary = new BiDictionary<string, int, string>();
            biDictionary.Add("Ivan", 1, "Petrov");
            biDictionary.Add("Cecka", 2, "Ceckova");

            Console.WriteLine(biDictionary.Find(1));
            Console.WriteLine(biDictionary.Find("Ivan"));
            Console.WriteLine(biDictionary.Find("Cecka", 2));
        }
    }
}
