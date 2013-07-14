using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Friends_of_Pesho
{
    class Program
    {

        static string[] firstLine = Console.ReadLine().Split(' ');
        static int pointsOnMap = int.Parse(firstLine[0]);
        static int streatsCount = int.Parse(firstLine[1]);
        static int hospitalsCount = int.Parse(firstLine[2]);

        static int[] distance = new int[pointsOnMap + 1];
        static int?[] previous = new int?[pointsOnMap + 1];
        static HashSet<int> setOfNodes = new HashSet<int>();

        public static void Dijkstra(int[,] graph, int source)
        {
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                distance[i] = int.MaxValue;
                previous[i] = null;
                setOfNodes.Add(i);
            }

            distance[source] = 0;

            while (setOfNodes.Count != 0)
            {
                int minNode = int.MaxValue;
                int minDistance = int.MaxValue;

                foreach (var node in setOfNodes)
                {
                    if (minDistance > distance[node])
                    {
                        minNode = node;
                        minDistance = distance[node];
                    }
                }

                setOfNodes.Remove(minNode);

                if (minNode == int.MaxValue)
                {
                    break;
                }

                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[minNode, i] > 0)
                    {
                        int potencialDistance = distance[minNode] + graph[minNode, i];

                        if (potencialDistance < distance[i])
                        {
                            distance[i] = potencialDistance;
                            previous[i] = minNode;
                        }
                    }
                }
            }
        }

        public static void Main()
        {
            string[] secondLine = Console.ReadLine().Split(' ');
            int[] hospitals = new int[hospitalsCount];

            for (int i = 0; i < hospitalsCount; i++)
            {
                hospitals[i] = int.Parse(secondLine[i]);
            }

            int[,] graph = new int[pointsOnMap + 1, pointsOnMap + 1];

            for (int i = 0; i < streatsCount; i++)
            {
                string[] streetLine = Console.ReadLine().Split(' ');
                graph[int.Parse(streetLine[0]) - 1, int.Parse(streetLine[1]) - 1] = int.Parse(streetLine[2]);
                graph[int.Parse(streetLine[1]) - 1, int.Parse(streetLine[0]) - 1] = int.Parse(streetLine[2]);
            }

            SortedSet<int> result = new SortedSet<int>();

            for (int h = 0; h < hospitalsCount; h++)
            {
                int source = hospitals[h];

                Dijkstra(graph, source - 1);
                int tempResult = 0;
                for (int i = 0; i < distance.Length; i++)
                {
                    //Console.Write("Distance from 1 to {0}: ", i + 1);
                    if (distance[i] == int.MaxValue)
                    {
                        //Console.WriteLine("No path.");
                    }
                    else
                    {
                        //Console.Write("Path: ");

                        int? indexer = i;
                        while (indexer != source - 1)
                        {
                            indexer = previous[indexer.Value];
                        }

                        //Console.Write("1 ");

                        //Console.WriteLine("Distance: " + distance[i]);
                        if (!hospitals.Contains(i + 1))
                        {
                            //Console.WriteLine("ADDVAM " + distance[i]);
                            tempResult += distance[i];
                            //Console.Write(indexer + 1 + " ");
                        }

                    }
                    //Console.WriteLine(distance[i]);
                }
                result.Add(tempResult);
            }
            Console.WriteLine(result.Min);

           
        }
    }
    
}
