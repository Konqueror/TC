using System;

namespace Matrix
{
    class IO
    {
        static void Main()
        {
            //8 Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

            Matrix<int> matrixOne = new Matrix<int>(3, 3);
            Matrix<int> matrixTwo = new Matrix<int>(3, 3);
            // Fill the matrixes
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixOne[i, j] = 1;
                    matrixTwo[i, j] = 3;
                }
            }
            //9 Implement an indexer this[row, col] to access the inner matrix cells.
            Console.WriteLine(matrixOne[0, 0]);
            Console.WriteLine(matrixTwo[0, 0]);
            //Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
            //Throw an exception when the operation cannot be performed. 
            //Implement the true operator (check for non-zero elements).
            Matrix<int> matrixSum = matrixOne + matrixTwo;
            Matrix<int> matrixDifference = matrixOne + matrixTwo;

            if (matrixSum)
            {
                Console.WriteLine("True there is no zero elements");
            }
            else
            {
                Console.WriteLine("False There is zero elements");
            }
        }
    }
}
