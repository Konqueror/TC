using System;

namespace Lib
{
    class Calculations
    {
        // 3. Write a static class with a static method to calculate the distance between two points in the 3D space.

        // I use that algo http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php

        public static double Distance(Point3D PointA, Point3D PointB)
        {
            return Math.Sqrt((PointA.x - PointB.x) * (PointA.x - PointB.x) +
                             (PointA.y - PointB.y) * (PointA.y - PointB.y) +
                             (PointA.z - PointB.z) * (PointA.z - PointB.z));
        }
    }
}
