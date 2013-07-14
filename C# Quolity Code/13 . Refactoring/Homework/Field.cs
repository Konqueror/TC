using System;
using System.Linq;
using System.Text;

namespace GameFifteen
{
    public class Field
    {
        private int[,] matrix;

        private int size;

        public int[,] Matrix
        {
            get
            {
                return this.matrix;
            }
            set
            {
                this.matrix = value;
            }
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                size = value;
            }
        }

        public int AllCellsCount 
        {
            get
            {
                return size * size; 
            }
        }

        public Field(int size)
        {
            this.Size = size;
            this.Matrix = new int[size, size];
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.Matrix.GetLength(1); col++)
                {
                    result.AppendFormat("{0,3}", this.Matrix[row, col]);
                }

                result.Append("\n");
            }

            result.Length -= 1;
            return result.ToString();
        }
    }
}
