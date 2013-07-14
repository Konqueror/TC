using System;

namespace GameFifteen
{
    class StartGame
    {
        static void Main(string[] args)
        {
            const int StartPositionY = 0;
            const int StartPositionX = 0;

            int matrixDimentions = int.Parse(Console.ReadLine());

            Field field = new Field(matrixDimentions);
            CurrentPosition position = new CurrentPosition(StartPositionY, StartPositionX);

            Direction directionToGo = Compass.ChooseDirection(field, position);

            for (int i = 0; i < field.AllCellsCount; i++)
            {
                if (directionToGo == Direction.None)
                {
                    //TODO: Implement the teleport
                }
                else
                {
                    //TODO: Move that direction
                }
            }
        }
    }
}
