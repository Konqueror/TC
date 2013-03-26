using System;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(double width)
            : base(width, width)
        {
        }

        public override double CalculateSurface()
        {
            return Math.PI * (this.Width * this.Width);
        }
    }
}
