using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFifteen
{
    public class Compass
    {
        public static Direction ChooseDirection(Field field, CurrentPosition position)
        {
            if (position.Row == 0 && position.Col == 0)
            {
                //If it is first move the direction must be Southeast. Look at the task.
                return Direction.Southeast;
            }
            int directionsCount = Enum.GetNames(typeof(Direction)).Length;
            for (int i = 0; i <= directionsCount; i++)
            {
                Direction nextDirection = (Direction)((int)position.CurrentDirection) + i;
                position.Move(nextDirection);

                if (IsPositionCorect(field, position))
                {
                    return nextDirection;
                }
                else
                {
                    //TODO: Move back bevause position is invalid
                }
            }

            return Direction.None;
        }

        private static bool IsPositionCorect(Field field, CurrentPosition position)
        {
            bool isInsideField = position.Row <= field.Size && position.Col <= field.Size && position.Row >= 0 && position.Col >= 0;
            bool isEmotyCell = field.Matrix[position.Row, position.Col] == 0;
            
            if (isInsideField && isEmotyCell)
            {
                return true;
            }

            return false;
        }
    }
}
