//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(CalculateSurfaceSideAndAltitude(5, 10.6));
        Console.WriteLine(CalculateSurfaceThreeSides(10, 10, 5));
        Console.WriteLine(CalculateSurfaceTwoSidesAndAngle(10,15, 60));
    }
    static double CalculateSurfaceSideAndAltitude (double a, double ha)
    {
        return (a * ha) / 2;
    }
    static double CalculateSurfaceThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p*(p - a)*(p - b)*(p - c));
    }
    static double CalculateSurfaceTwoSidesAndAngle(double a, double b, double angleAB)
    {
        return (a*b*Math.Sin(angleAB)/2);
    }
}

