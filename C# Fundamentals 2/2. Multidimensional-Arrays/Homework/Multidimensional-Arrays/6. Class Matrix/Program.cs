 //Write a class Matrix, to holds a matrix of integers. 
 //Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
using System;
using System.Text;
class Program
{
    static void Main()
    {
        Matrix matrixOne = new Matrix(5, 5);
        Matrix matrixTwo = new Matrix(5, 5);

        // Fill matrixOne and matrixTwo
        int value = 0;
        for (int x = 0; x < matrixOne.rows; x++)
        {
            for (int y = 0; y < matrixOne.cols; y++)
            {
                matrixOne[x, y] = value;
                value++;
                matrixTwo[x, y] = value;
                value++;
            }
        }

        Console.WriteLine("Matrix one:");
        Console.WriteLine(matrixOne);
        Console.WriteLine("Matrix two:");
        Console.WriteLine(matrixTwo);
        Console.WriteLine("Matrix one + Matrix two");
        Console.WriteLine(matrixOne + matrixTwo);
        Console.WriteLine("Matrix one - Matrix two");
        Console.WriteLine(matrixOne - matrixTwo);
        Console.WriteLine("Matrix one * Matrix two");
        Console.WriteLine(matrixOne * matrixTwo);

    }
}
class Matrix
{
    public int[,] matrix;
    public int rows, cols;

    public Matrix(int x, int y)
    {
        matrix = new int[x, y];
        rows = y;
        cols = x;
    }

    public int this[int x, int y]
    {
        get
        {
            return matrix[x, y];
        }
        set
        {
            matrix[x, y] = value;
        }
    }

    public static Matrix  operator +(Matrix first, Matrix second)
    {
        if (first.rows != second.rows || first.cols != second.cols)
        {
            throw new Exception("The dimensions are not the same!");
        }

        Matrix result = new Matrix(first.rows, first.cols);

        for (int i = 0; i < first.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < second.matrix.GetLength(1); j++)
            {
                result[i, j] = first[i, j] + second[i, j];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix first, Matrix second)
    {
        if (first.rows != second.rows || first.cols != second.cols)
        {
            throw new Exception("The dimensions are not the same!");
        }

        Matrix result = new Matrix(first.rows, first.cols);

        for (int i = 0; i < first.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < second.matrix.GetLength(1); j++)
            {
                result[i, j] = first[i, j] - second[i, j];
            }
        }
        return result;
    }
    public static Matrix operator *(Matrix first, Matrix second)
    {
        if (first.rows != second.cols)
        {
            throw new Exception("The rows of the first matrix arn not the same like the cols in the second matrix.");
        }
        Matrix result = new Matrix(first.cols, second.rows);

        for (int i = 0; i < first.rows; i++)
        {
            for (int j = 0; j < second.cols; j++)
            {
                for (int row = 0; row < first.cols; row++)
                {
                    result[i, j] = result[i, j] + first[i, row] * second[row, j];
                }
            }
        }
        return result;
    }


    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                result.AppendFormat("{0, 5}", matrix[i, j]);
            }
            result.Append("\n");
        }
        return result.ToString() ;
    }
}
