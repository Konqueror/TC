namespace Shapes
{
    class Rectangle : Shape
    {
        //Constructor
        public Rectangle(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
