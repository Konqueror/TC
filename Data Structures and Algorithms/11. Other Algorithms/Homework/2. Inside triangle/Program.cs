using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Inside_triangle
{
    class Program
    {
        static void Main(string[] args)
        {


            double x1 = 1;
            double y1 = 1;
            double x2 = 5;
            double y2 = 1;
            double x3 = 3;
            double y3 = 5;

            double x4 = 4;
            double y4 = 2;

            double dx = (x4 - x3);
            double dy = (y4 - y3);

            double A = x1 - x3;
            double B = y1 - y3;
            double C = x2 - x3;
            double D = y2 - y3;

            double denom = A * D - B * C;

            double alpha = D * dx - C * dy;
            alpha /= denom;

            double beta = -B * dx + A * dy;
            beta /= denom;

            double gamma = 1.0 - (alpha + beta);

            if (alpha >= 0 && beta >= 0 && gamma >= 0)
            {
                Console.WriteLine("Point is inside the triangle.");

            }
            else
            {
                Console.WriteLine("Point is outside the triangle.");
            }
        }
    }
}
