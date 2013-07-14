using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_and_Traversals
{
    class Program
    {

        static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "The tree has no root.");
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        private static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static void PrintAllPathsWithSumS(Node<int> root, int sum, int tempSum, string path)
        {
            if (tempSum == sum)
            {
                Console.WriteLine(path);
            }
            else
            {
                foreach (var child in root.Children)
                {
                    PrintAllPathsWithSumS(child, sum, tempSum + child.Value, path + " -> " + child.Value);
                }

            }
        }

        static void SubtreesSum(int sum, int numberOfNodes, Node<int>[] nodes)
        {
            for (int i = 0; i < numberOfNodes; i++)
            {
                PrintAllPathsWithSumS(nodes[i], sum, nodes[i].Value, nodes[i].Value.ToString());
            }
        }
        static void Main()
        {
            int length   = int.Parse(Console.ReadLine());
            Node<int>[] nodes = new Node<int>[length];

            for (int i = 0; i < length; i++)
            {
                nodes[i] = new Node<int>(i);
            }
            for (int i = 1; i <= length - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            // 1. Find the root
            Node<int> root = FindRoot(nodes);
            Console.WriteLine("Thee root is: " + root.Value);

            // 2. Find all leafs
            List<Node<int>> leafs = FindAllLeafs(nodes);
            Console.Write("Leafs: ");
            foreach (var leaf in leafs)
            {
                Console.Write("{0}, ", leaf.Value);
            }

            //3 Find middle notes
            List<Node<int>> middle = FindAllMiddleNodes(nodes);
            Console.Write("Middle notes: ");
            foreach (var leaf in middle)
            {
                Console.Write("{0}, ", leaf.Value);
            }

            //4. Find the longest path
            int longest = FindLongestPath(root);
            Console.WriteLine("The longest path is: " + longest);

            //5. Find all paths in the tree with given sum S of their nodes
            int wantedSum = 9;
            Console.WriteLine("All paths with sum : " + wantedSum + " starting from the root are:");
            PrintAllPathsWithSumS(root, wantedSum, root.Value, root.Value.ToString());

            //6. All subtries with current sum 
            Console.WriteLine("All subtries with a sum"+ wantedSum + " are :");
            SubtreesSum(11, length, nodes);
        }
    }
}
