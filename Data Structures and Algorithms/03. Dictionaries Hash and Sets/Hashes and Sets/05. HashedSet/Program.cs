using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HashedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashedSet<string> hashTest = new HashedSet<string>();

            hashTest.Add("Fats");
            hashTest.Add("Cola");
            
            Console.WriteLine(hashTest["Fats"]);
            hashTest.Remove("Fats");

        }
    }
}
