//5. Implement a TrailObject class. It should inherit the GameObject class and should have a constructor which takes an additional 
//"lifetime" integer. The TrailObject should disappear after a "lifetime" amount of turns. You must NOT edit any existing .cs file. 
//Then test the TrailObject by adding an instance of it in the engine through the AcademyPopcornMain.cs file.

using System;
using System.Linq;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        private int lifeTime;
        
        public int LifeTime
        {
            get
            {
                return this.lifeTime;
            }
            set
            {
                this.lifeTime = value;
            }
        }
        
        public new const string CollisionGroupString = "trailObject";

        public TrailObject(MatrixCoords topLeft, int lifeTime, char[,] model)
            : base(topLeft, model)
        {
            this.LifeTime = lifeTime;
        }

        public override void Update()
        {
            if (LifeTime != -1)
            {
		        LifeTime--;
                if (LifeTime == 0)
	            {
		            this.IsDestroyed = true;
	            }
            }
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return Block.CollisionGroupString;
        }
    }
}
