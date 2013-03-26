using System;

namespace Shapes
{
    abstract class Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        //Constructor
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}
