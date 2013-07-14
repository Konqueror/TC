using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedMultiDictionary<uint, Article> articlesArhive = new OrderedMultiDictionary<uint, Article>(true);
            Console.WriteLine("Loading 1 000 000 to the momery.");
            for (uint i = 0; i < 1000000; i++)
            {
                articlesArhive.Add(i , new Article("Random Title", i ,"Random Vendor", 508504778));
            }
            Console.WriteLine("Make a seach:");
            var result = articlesArhive.Range(900000, true, 900800, true).Values.OrderBy(article => article.Price);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
