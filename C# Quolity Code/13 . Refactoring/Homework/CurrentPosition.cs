using System;
using System.Linq;

namespace GameFifteen
{
    public class CurrentPosition
    {
        public Direction CurrentDirection;
 
        private int stepsMade;

        public int StepsMade
        {
            get
            {
                return this.stepsMade;
            }
            private set
            {
                this.stepsMade = value;
            }
        }

        public CurrentPosition(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.StepsMade = 1;
        }

        public int Row { get; private set; }

        public int Col { get; private set; }

        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Southeast:
                    this.Row++;
                    this.Col++;
                    break;
                case Direction.South:
                    this.Row++;
                    break;
                case Direction.Southwest:
                    this.Row++;
                    this.Col--;
                    break;
                case Direction.West:
                    this.Col--;
                    break;
                case Direction.Northwest:
                    this.Row--;
                    this.Col--;
                    break;
                case Direction.North:
                    this.Row--;
                    break;
                case Direction.Northeast:
                    this.Row--;
                    this.Col++;
                    break;
                case Direction.East:
                    this.Col++;
                    break;
                default:
                    throw new ArgumentException("Invalid Direction!");
            }
        }
    }
}
