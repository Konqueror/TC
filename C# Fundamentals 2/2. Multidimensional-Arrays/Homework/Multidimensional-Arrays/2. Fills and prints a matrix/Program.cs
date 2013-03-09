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

        // Fill it
        for (int j = 0; j < n; j++)
        {
            if ((j % 2) == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i, j] = counter;
                    counter++;
                }
            }

            else
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    array[i, j] = counter;
                    counter++;
                }
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
