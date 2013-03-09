//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file.
using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../matrix.txt");
        using (reader)
        {
            int dim = int.Parse(reader.ReadLine());
            int[,] matrix = new int[dim, dim];
            string rowData;
            for (int row = 0; row < dim; row++)
            {
                rowData = reader.ReadLine();
                string[] rowCells = rowData.Split(' ');
                for (int col = 0; col < dim; col++)
                {
                    matrix[row, col] = int.Parse(rowCells[col]);
                }
            }

            int sum = 0;
            int tempSum = 0;
            //Find the square 
            for (int row = 0; row <= dim - 2; row++)
            {
                for (int col = 0; col <= dim - 2; col++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            tempSum = tempSum + matrix[row + i, col + j];
                        }
                    }
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                    }
                    tempSum = 0;
                }
            }
            StreamWriter writer = new StreamWriter("../../result.txt");
            using (writer)
            {
                writer.WriteLine(sum);
            }
        }
        Console.WriteLine("Done!");
    }
}

