using System.Collections.Generic;

namespace AcademyPopcorn
{
    class ShootingRacket : Racket
    {
        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> makeBullet = new List<GameObject>();
            makeBullet.Add(new Bullet(this.topLeft));
            return makeBullet;
        }
    }
}
