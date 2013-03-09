using System;
using Lib;

namespace Homework
{
    class IO
    {
        static void Main()
        {
            // 1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
            //Implement the ToString() to enable printing a 3D point.

            Point3D RandomPoint = new Point3D(1, 2, 3);
            Console.WriteLine("Random Point:");
            Console.WriteLine(RandomPoint.ToString());

            // 2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
            // Add a static property to return the point O.
            Console.WriteLine("Starting Point O:");
            Console.WriteLine(Point3D.StartPointO());

            //3 Write a static class with a static method to calculate the distance between two points in the 3D space.
            Point3D PointA = new Point3D(1, 2, 4);
            Point3D PointB = new Point3D(3, 4, 5);
            Console.WriteLine("Calculate Distance between two points: ");
            Console.WriteLine(Lib.Calculations.Distance(PointA, PointB));

            //4 Create a class Path to hold a sequence of points in the 3D space. 
            //Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
            Path pathList = new Path();
            pathList.path.Add(PointA);
            pathList.path.Add(PointB);
            Console.WriteLine("First point of sequence of points");
            Console.WriteLine(pathList.path[0]);
            //Save and load
            PathStorage.SavePath(pathList);
            Path LoadedList = PathStorage.LoadPath("../../path.txt");
        }
    }
}
