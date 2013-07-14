using System;

public class Methods
{
    public static double CalcTriangleArea(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("Sides should be positive.");
        }
        double halfPerimeter = (a + b + c) / 2;
        //http://en.wikipedia.org/wiki/Heron%27s_formula
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

        return area;
    }

    public static string DigitToWord(short digit)
    {
        switch (digit)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: throw new ArgumentException("Argument is not a digit!");
        }

    }

    public static int GetMax(params int[] elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException("elements are null.");
        }

        if (elements.Length == 0)
        {
            throw new ArgumentException("No elements specified.");
        }

        int max = elements[0];

        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }

        return max;
    }

    public static void PrintNumber(double value, int decimalPlaces)
    {
        string format = "{0:F" + decimalPlaces + "}";
        Console.WriteLine(format, value);
    }

    public static void PrintPercent(double value)
    {
        Console.WriteLine("{0:P0}", value);
    }

    public static void PrintAligned(object value, int width)
    {
        string format = "{0," + width + "}";
        Console.WriteLine(format, value);
    }

    public static double CalcDistance(double x1, double x2, double y1, double y2)
    {
        double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

        return distance;
    }

    public static bool IsHorizontalLine(double x1, double x2, double y1, double y2)
    {
        if (x1 == x2 && y1 == y2)
        {
            throw new ArgumentException("A single point can't define a line.");
        }

        return y1 == y2;
    }

    public static bool IsVerticalLine(double x1, double x2, double y1, double y2)
    {
        if (x1 == x2 && y1 == y2)
        {
            throw new ArgumentException("A single point can`t define a line.");
        }

        return x1 == x2;
    }
}

