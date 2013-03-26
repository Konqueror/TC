//Implement a Gift class. It should be a moving object, which always falls down. 
//The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket.
//You must NOT edit any existing .cs file. 
using System.Collections.Generic;

namespace AcademyPopcorn
{
    class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '☺' } }, new MatrixCoords(1, 0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> shooterList = new List<GameObject>();
            if (this.IsDestroyed == true)
            {
                ShootingRacket shooter = new ShootingRacket(new MatrixCoords(topLeft.Row + 1, topLeft.Col), 6);
                shooterList.Add(shooter);
                return shooterList;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
