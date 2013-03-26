namespace AcademyPopcorn
{
    class Exploder : MovingObject
    {
        public Exploder(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { '%' } }, speed)
        {
        }
        public override void Update()
        {
            this.IsDestroyed = true;
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }

        public override string GetCollisionGroupString()
        {
            return Ball.CollisionGroupString;
        }
    }
}
