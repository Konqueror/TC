using System;

class Program
{
    static void Main()
    {
        string[,] array = { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
        int x = 4;
        int y = 3;
        int length = 1;
        int maxLength = 0;
        string bestElement = "";
        int tempCol = 0;
        // check rolls
        for (int col = 0; col < y; col++)
        {
            for (int row = 0; row < x - 1; row++)
            {
                if (array[col, row] == array[col, row + 1])
                {
                    length++;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        bestElement = array[col, row];
                    }
                    length = 1;
                }
            }
            // In case if the maximal sequence of equal elements is in the end of the array
            if (length > maxLength)
            {
                maxLength = length;
                bestElement = array[col, x-1];
            }
        }

        // Chek colls
        for (int row = 0; row < x; row++)
        {
            for (int col = 0; col < y - 1; col++)
            {
                if (array[col, row] == array[col + 1, row])
                {
                    length++;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        bestElement = array[col, row];
                    }
                    length = 1;
                }
            }
            // In case if the maximal sequence of equal elements is in the end of the array
            if (length > maxLength)
            {
                maxLength = length;
                bestElement = array[y-1, row];
            }
        }
        // Right Diagonal
        // Diagonals doesnt work :(       
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write("{0}, ", bestElement);
        }
    }    
}