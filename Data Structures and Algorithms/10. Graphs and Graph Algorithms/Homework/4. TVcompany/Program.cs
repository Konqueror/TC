using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaGraph
{
    class Program
    {
        static void Main()
        {
            OGraph myGraph = new OGraph();
            // add the vertices
            myGraph.Vertices.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            // add the edges
            myGraph.Edges.Add(new Edge(1, 2));
            myGraph.Edges.Add(new Edge(1, 4));
            myGraph.Edges.Add(new Edge(2, 4));
            myGraph.Edges.Add(new Edge(2, 3));
            myGraph.Edges.Add(new Edge(2, 5));
            myGraph.Edges.Add(new Edge(2, 6));
            myGraph.Edges.Add(new Edge(4, 5));
            myGraph.Edges.Add(new Edge(4, 7));
            myGraph.Edges.Add(new Edge(5, 6));
            myGraph.Edges.Add(new Edge(6, 7));
            myGraph.Edges.Add(new Edge(6, 8));


            GraphAlgorithm algorithm = new GraphAlgorithm(myGraph);

            OGraph minSpanningTreeByPrim = algorithm.CreateOptimalSpanningTree(OGraph.OptimalType.Minimum, GraphAlgorithm.AlgorithmType.Prim);

            Console.WriteLine("Prim's Algorithm");

            foreach (Edge edge in minSpanningTreeByPrim.Edges)
                Console.WriteLine(edge);
        }
    }
}
