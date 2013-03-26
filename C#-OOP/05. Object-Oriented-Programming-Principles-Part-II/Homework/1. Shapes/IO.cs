//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//(height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at 
//initialization height must be kept equal to width and implement the CalculateSurface() method. 
//Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) 
//stored in an array.

using System;

namespace Shapes
{
    class IO
    {
        static void Main()
        {
            Shape[] testShapes = new Shape[]
            {
                new Triangle(2.0, 2.2),
                new Rectangle(2.0, 2.0),
                new Circle(2.0)
            };

            for (int i = 0; i < testShapes.Length; i++)
            {
                Console.WriteLine(testShapes[i].CalculateSurface());
            }

        }
    }
}
