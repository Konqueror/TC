using System;
using System.Collections.Generic;
using System.Linq;

namespace DijkstraLINQ
{
    public class DijkstraTest
    {
        public static void Main()
        {
            Graph graph = new Graph();
            
            string[] firstLine = Console.ReadLine().Split(' ');
            string pointsOnMap = firstLine[0];
            string streatsCount = firstLine[1];
            string hospitalsCount = firstLine[2];

            string[] secondLine = Console.ReadLine().Split(' ');
            string[] hospitals = new string[int.Parse(hospitalsCount)];

            for (int i = 0; i < int.Parse(hospitalsCount); i++)
            {
                hospitals[i] = secondLine[i];
            }

            for (int i = 1; i <= int.Parse(pointsOnMap); i++)
            {
                graph.AddNode(i.ToString());
            }

            for (int i = 0; i < int.Parse(streatsCount); i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                graph.AddConnection(line[0], line[1], int.Parse(line[2]), true);
            }
            List<int> results = new List<int>();

            for (int i = 0; i < hospitals.Length; i++)
            {
                int result = 0;
                var calculator = new DistanceCalculator();
                var distances = calculator.CalculateDistances(graph, hospitals[i]);
                //Console.WriteLine("from " + hospitals[i]);
                foreach (var d in distances)
                {
                    if (hospitals.Contains(d.Key))
                    {
                        continue;
                    }
                    result += (int)d.Value;
                    //Console.WriteLine("{0}, {1}", d.Key, d.Value);
                }
                results.Add(result);
            }
            Console.WriteLine(results.Min());
        }
    }
}
