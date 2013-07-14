using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_shortest_steps
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Tuple<int, List<int>> element = new Tuple<int, List<int>>(start, new List<int>());
            Queue<Tuple<int, List<int>>> list = new Queue<Tuple<int, List<int>>>();
            
            list.Enqueue(element);
            while (true)
            {
                var current = list.Dequeue();
                List<int> currentPath = current.Item2.ToList();
                currentPath.Add(current.Item1);
                list.Enqueue(new Tuple<int, List<int>>(current.Item1 + 1, currentPath));
                list.Enqueue(new Tuple<int, List<int>>(current.Item1 + 2, currentPath));
                list.Enqueue(new Tuple<int, List<int>>(current.Item1 * 2, currentPath));
                
                if (current.Item1 == end)
                {
                    Console.WriteLine(string.Join(" -> ", current.Item2) + " -> " +  end);
                    Console.Write(current.Item1);
                    break;
                }
            }
        }

    }

}