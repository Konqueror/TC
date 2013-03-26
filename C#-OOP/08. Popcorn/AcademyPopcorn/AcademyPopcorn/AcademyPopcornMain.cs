using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            //1. Create side and ceiling walls to the game
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock currBlock = new IndestructibleBlock(new MatrixCoords(i, 0));

                engine.AddObject(currBlock);
            }
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock currBlock = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));

                engine.AddObject(currBlock);
            }
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock currBlock = new IndestructibleBlock(new MatrixCoords(0, i));

                engine.AddObject(currBlock);
            }
            ////////////////////////////////////////////////

            //Trail Object
            TrailObject trailObject = new TrailObject(new MatrixCoords(10, 4), 50, new char[,] { { 'T' } });

            engine.AddObject(trailObject);
            //Meteor ball
            MeteoriteBall meteor = new MeteoriteBall(new MatrixCoords(9, 9), new MatrixCoords(-1, 1));

            engine.AddObject(meteor);

            //GiftBlock
            GiftBlock giftBlack = new GiftBlock(new MatrixCoords(12,20));

            engine.AddObject(giftBlack);
            
            //UnstoppableBall
            UnstoppableBall unstoppable = new UnstoppableBall(new MatrixCoords(8, 4), new MatrixCoords(-1, 1));

            engine.AddObject(unstoppable);

            //Explosion 
            ExplodingBlock explode = new ExplodingBlock(new MatrixCoords(4, 13));

            engine.AddObject(explode);

            // Unpassable blacks
            for (int i = 0; i < WorldCols- 25; i++)
            {
                UnpassableBlock unpass = new UnpassableBlock(new MatrixCoords(2, i));

                engine.AddObject(unpass);
            }

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
