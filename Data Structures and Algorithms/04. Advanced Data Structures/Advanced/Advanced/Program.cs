using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> prQueue = new PriorityQueue<int>();

            prQueue.Enqueue(10);
            prQueue.Enqueue(2);
            prQueue.Enqueue(5);
            prQueue.Enqueue(4);

            Console.WriteLine(prQueue.Dequeue());
            Console.WriteLine(prQueue.Dequeue());
            Console.WriteLine(prQueue.Dequeue());
            Console.WriteLine(prQueue.Dequeue());
        }
    }
}
