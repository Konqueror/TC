using System;

class Program
{
    static void Main()
    {
        string strNum;
        int n;
        do
        {
            Console.Write("Enter the size: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number
        int[,] array = new int[n, n];
        int counter = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            for (int col = 0; col < n - i; col++)
            {
                array[i + col, col] = counter++;
            }
        }
        for (int j = 1; j < n; j++)
        {
            for (int row = 0; row < n - j; row++)
            {
                array[row, j + row] = counter++;
            }
        }

        // Show the matrix

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
