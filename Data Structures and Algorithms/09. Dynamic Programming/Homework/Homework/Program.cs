using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //I use the algo. from this tutorial http://www.youtube.com/watch?v=EH6h7WA7sDw

            Product[] products = new Product[6];
            products[0] = new Product("beer", 3, 2);
            products[1] = new Product("vodka", 8, 12);
            products[2] = new Product("cheese", 4, 5);
            products[3] = new Product("nuts", 1, 4);
            products[4] = new Product("ham", 2, 3);
            products[5] = new Product("whiskey", 8, 13);
            int capacity = 10; // M in the task
            
            int[,] choseMatrix = new int[products.Length + 1, capacity];
            int[,] keep = new int[products.Length + 1, capacity];

            for (int y = 1; y < products.Length + 1; y++)
            {
                for (int x = 0; x < capacity; x++)
                {
                    if (products[y - 1].Weigth > x + 1)
                    {
                        choseMatrix[y, x] = 0;
                        keep[y, x] = 0;
                    }
                    else
                    {
                        int itemToAdd = (x + 1)  - products[y - 1].Weigth - 1;
                        if (itemToAdd < 0)
                        {
                            itemToAdd = 0;
                        }

                        if (choseMatrix[y - 1, x] > products[y - 1].Cost + choseMatrix[y - 1, itemToAdd])
                        {
                            choseMatrix[y, x] = choseMatrix[y - 1, x];
                            keep[y, x] = 0;
                        }
                        else
                        {
                            choseMatrix[y, x] = products[y - 1].Cost + choseMatrix[y - 1, itemToAdd];
                            keep[y, x] = 1;
                        }
                    }
                    //Console.Write(choseMatrix[y, x]); For debuging
                }
                //Console.WriteLine();
            }

            int itemsLeft = products.Length;
            int capacityleft = capacity;

            while (itemsLeft > 0)
            {
                if (keep[itemsLeft, capacityleft - 1] == 1)
                {
                    Console.WriteLine(products[itemsLeft - 1]);
                    capacityleft -= products[itemsLeft - 1].Weigth;
                    itemsLeft--;
                }
                itemsLeft--;
            }

            //Print(keep); //For debuging
        }

        static void Print(int[,] array)
        {
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write(array[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
