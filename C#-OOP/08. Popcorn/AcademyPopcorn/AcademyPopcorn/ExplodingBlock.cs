//Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. 
//You must NOT edit any existing .cs file. Hint: what does an explosion "produce"?
using System.Collections.Generic;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block
    {
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = '@';
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed == true)
            {
                List<MovingObject> explosions = new List<MovingObject>();

                explosions.Add(new Exploder(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col - 1), new MatrixCoords(0, 0)));
                explosions.Add(new Exploder(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col + 1), new MatrixCoords(0, 0)));
                explosions.Add(new Exploder(new MatrixCoords(this.TopLeft.Row - 1, this.TopLeft.Col), new MatrixCoords(0, 0)));
                explosions.Add(new Exploder(new MatrixCoords(this.TopLeft.Row + 1, this.TopLeft.Col), new MatrixCoords(0, 0)));

                return explosions;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
