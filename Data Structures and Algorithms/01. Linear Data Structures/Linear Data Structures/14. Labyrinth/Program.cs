using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Program
    {
        public const int labyrinthSize = 6;
        public static string[,] labyrinth = new string[labyrinthSize, labyrinthSize]
                                            {
                                             {"0", "0", "0", "x", "0", "x"},
                                             {"0", "x", "0", "x", "0", "x"},
                                             {"0", "*", "x", "0", "x", "0"},
                                             {"0", "x", "0", "0", "0", "0"},
                                             {"0", "0", "0", "x", "x", "0"},
                                             {"0", "0", "0", "x", "0", "x"}
                                            };


        static void Main()
        {
            int startY = 2;
            int startX = 0;
            //Place on start position
            walkInLabyrinth(startY, startX, "0");

            //Print Labyrinth
            for (int row = 0; row < labyrinthSize; row++)
            {
                for (int col = 0; col < labyrinthSize; col++)
                {
                    //That is slow. TODO: Use string builder
                    Console.Write("{0,3}", labyrinth[row, col]);
                }
                Console.WriteLine();
            }

        }

        static void walkInLabyrinth(int currentY, int currentX, string place)
        {
            if (currentY >= labyrinth.GetLength(0) || currentX >= labyrinth.GetLength(1) ||
              currentY < 0 || currentX < 0)
            {
                return;
            }

            if (place == "x" || place == "*" || labyrinth[currentY, currentX] != "0")
            {
                Console.WriteLine("Done");
                return;
            }

            int currNumber = int.Parse(place);
            currNumber++;
            labyrinth[currentY, currentX] = currNumber.ToString();

            walkInLabyrinth(currentY, currentX - 1, labyrinth[currentY, currentX]);
            walkInLabyrinth(currentY - 1, currentX, labyrinth[currentY, currentX]);
            walkInLabyrinth(currentY + 1, currentX, labyrinth[currentY, currentX]);
            walkInLabyrinth(currentY, currentX + 1, labyrinth[currentY, currentX]);
        }


    }   
}
