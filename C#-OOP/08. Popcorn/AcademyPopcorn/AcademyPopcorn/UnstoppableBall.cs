using System.Collections.Generic;

namespace AcademyPopcorn
{
    class UnstoppableBall: Ball
    {
        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket"
                || otherCollisionGroupString == "block"
                || otherCollisionGroupString == "unpassableBlock";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            List<string> collisionObjects = collisionData.hitObjectsCollisionGroupStrings;
            foreach (var collision in collisionObjects)
            {
                if (collision.Equals("unpassableBlock") || collision.Equals("racket"))
                {
                    base.RespondToCollision(collisionData);
                }
            }
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }

    }
}
