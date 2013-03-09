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
            int start = 0;
            int end = n;

            do
            {
                for (int row = start; row < end; row++)
                {
                    array[row, start] = counter;
                    counter++;
                }

                for (int col = start + 1; col < end; col++)
                {
                    array[end - 1, col] = counter;
                    counter++;
                }

                for (int row = end - 2; row >= start; row--)
                {
                    array[row, end - 1] = counter;
                    counter++;
                }

                for (int col = end - 2; col >= start + 1; col--)
                {
                    array[start, col] = counter;
                    counter++;
                }
                start++;
                end--;
            }
            while (end - start > 0);


            // Show that matrix
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
