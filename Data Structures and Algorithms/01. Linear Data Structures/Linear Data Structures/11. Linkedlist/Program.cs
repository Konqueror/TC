using System;
using System.Linq;

namespace Linkedlist
{
    class Program
    {
        static void Main()
        {
            Linkedlist<int> magicList = new Linkedlist<int>(1);

            magicList.AddNode(2);
            magicList.AddNode(3);
            magicList.AddNode(3);
            magicList.AddNode(4);
            magicList.AddNode(5);
            magicList.AddNode(6);
            magicList.AddNode(200);

            Console.WriteLine(magicList);
        }
    }
}
