using System;
using System.Linq;

namespace Hash_table
{
    class Program
    {
        static void Main()
        {
            HashTable<int, string> hashTest = new HashTable<int, string>();

            hashTest.Add("Fats" , 1);
            hashTest.Add("Cola", 15);
            hashTest["Hamburgars"] = 30;

            Console.WriteLine(hashTest.Find("Hamburgars"));
            Console.WriteLine(hashTest["Fats"]);
            hashTest.Remove("Fats");

            foreach (var item in hashTest)
            {
                Console.WriteLine(item.Value);
            }


        }
    }
}
