using System;

namespace Matrix
{
    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        // Constructor
        public Matrix(int row, int col)
        {
            this.rows = row;
            this.cols = col;
            this.matrix = new T[row, col];
        }
        // 9.Implement an. indexer this[row, col] to access the inner matrix cells

        public T this[int row, int col]
        {
            get
            {
                if (row <= this.rows && col <= this.cols)
                {
                    return matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out side of the matrix;");
                }
            }
            set
            {
                if (row <= this.rows && col <= this.cols)
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out side of the matrix;");
                }
            }
        }
        //Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.rows != secondMatrix.rows || firstMatrix.cols != secondMatrix.cols)
            {
                throw new InvalidOperationException("The matrixes have different sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);

            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];

                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.rows != secondMatrix.rows || firstMatrix.cols != secondMatrix.cols)
            {
                throw new InvalidOperationException("The matrixes have different sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);

            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];

                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.rows != secondMatrix.cols)
            {
                throw new InvalidOperationException("Rows of the first first matrix must be same as the columns of the second matrix!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.rows, secondMatrix.cols);

            for (int i = 0; i < firstMatrix.rows; i++)
            {
                for (int j = 0; j < firstMatrix.cols; j++)
                {
                    for (int k = 0; k < firstMatrix.cols; k++)
                    {
                        result[i, j] += (dynamic)firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }
            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
