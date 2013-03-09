using System;

class Program
{
    static void Main()
    {
        string strNum;
        int height;
        int weight;
        do
        {
            Console.Write("Enter the height of the matrix (bigger than 3): ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out height) || height <= 3); // check if it is a real number

        do
        {
            Console.Write("Enter the weight of the matrix (bigger than 3): ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out weight) || weight <= 3); // check if it is a real number
        Console.WriteLine("Input a matrix {0}x{1} separate each element with spaces:", height ,weight);

        int[,] array = new int[height, weight];
        // Input the matrix
        for (int row = 0; row < height; row++)
        {
            string rowData = Console.ReadLine();
            string[] rowCells = rowData.Split(' ');
            for (int col = 0; col < weight; col++)
            {
                array[row, col] = int.Parse(rowCells[col]);
            }
        }
        int sum = 0;
        int tempSum = 0;
        int x = 0, y = 0;
        //Find the square 
        for (int row = 0; row <= height - 3; row++)
        {
            for (int col = 0; col <= weight - 3; col++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        tempSum = tempSum + array[row+i,col+j];
                    }
                }
                if (tempSum > sum)
                {
                    sum = tempSum;
                    x = col;
                    y = row;
                }
                tempSum = 0;
            }
        }
        Console.WriteLine("3 x 3 that has maximal sum of its elements is: ");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0,3}",array[y + i, x + j]);
            }
            Console.WriteLine();
        }
    }
}

