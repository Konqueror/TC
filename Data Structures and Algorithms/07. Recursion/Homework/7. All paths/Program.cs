using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.All_paths
{
    class Program
    {
        static string[,] matrix;
        static List<char> path;

        static void Main(string[] args)
        {
            const int n = 5;
            matrix = new string[n, n] 
            {
                {"s", " ", " ", " ", "e"}, 
                {" ", "*", "*", "*", " "}, 
                {" ", "*", "*", "*", " "}, 
                {" ", "*", "*", "*", " "}, 
                {" ", " ", " ", " ", " "}, 
            };

            path = new List<char>();

            FindPaths(0, 0, 'S');

        }
        
        public static void FindPaths(int row, int col, char direction)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return;
            }

            if (col < 0 || col >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[row, col] == "*" ||
                matrix[row, col] == "@") // @ is current position
            {
                return;
            }

            if (matrix[row, col] == "e")
            {
                Console.WriteLine("Path available: " + string.Join(" -> ", path));
                return;
            }

            path.Add(direction);
            matrix[row, col] = "@";

            FindPaths(row + 1, col, 'D');
            FindPaths(row - 1, col, 'U');
            FindPaths(row, col + 1, 'R');
            FindPaths(row, col - 1, 'L');

            matrix[row, col] = " ";
            path.RemoveAt(path.Count - 1);
        }
        
    }
}
