using System;

namespace ClassUsingDemo
{
    internal class Demo
    {
        static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.DigitToWord(5));

            Console.WriteLine(Methods.GetMax(5, -1, 3, 2, 14, 2, 3));
            Methods.PrintNumber(1.3, 2);
            Methods.PrintPercent(0.75);
            Methods.PrintAligned(2.30, 8);

            Console.WriteLine(Methods.CalcDistance(3, 3, -1, 2.5));
            Console.WriteLine("Horizontal: " + Methods.IsHorizontalLine(3, 3, -1, 2.5));
            Console.WriteLine("Vertical: " + Methods.IsVerticalLine(3, 3, -1, 2.5));

            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 03, 17));

            Student stella = new Student("Stella", "Markova", "Sofia", new DateTime(1992, 03, 17), "Gamer");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
