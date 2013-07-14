using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MathWithPrimtiveTypes
{
    class Testing
    {
        public static void Main()
        {
            int testInt = 250;
            long testLong = 250;
            float testFloat = 250F;
            double testDouble = 250;
            // Write a program to compare the performance of add, subtract, increment, multiply, 	
            //for int, long, float, double and decimal values.

            ShowPreformance(() => Sum(testInt), "sum Int");
            ShowPreformance(() => Sum(testLong), "sum Long");
            ShowPreformance(() => Sum(testFloat), "sum Float");
            ShowPreformance(() => Sum(testDouble), "sum Double");

            ShowPreformance(() => Subtract(testInt), "Subtract Int");
            ShowPreformance(() => Subtract(testLong), "Subtract Long");
            ShowPreformance(() => Subtract(testFloat), "Subtract Float");
            ShowPreformance(() => Subtract(testDouble), "Subtract Double");

            ShowPreformance(() => Divide(testInt), "Divide Int");
            ShowPreformance(() => Divide(testLong), "Divide Long");
            ShowPreformance(() => Divide(testFloat), "Divide Float");
            ShowPreformance(() => Divide(testDouble), "Divide Double");

            ShowPreformance(() => Multiply(testInt), "Multiply Int");
            ShowPreformance(() => Multiply(testLong), "Multiply Long");
            ShowPreformance(() => Multiply(testFloat), "Multiply Float");
            ShowPreformance(() => Multiply(testDouble), "Multiply Double");

            //Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.
            ShowPreformance(() => SQRT(testInt), "SQRT Int");
            ShowPreformance(() => SQRT(testLong), "SQRT Long");
            ShowPreformance(() => SQRT(testFloat), "SQRT Float");
            ShowPreformance(() => SQRT(testDouble), "SQRT Double");

            ShowPreformance(() => Log(testInt), "Log Int");
            ShowPreformance(() => Log(testLong), "Log Long");
            ShowPreformance(() => Log(testFloat), "Log Float");
            ShowPreformance(() => Log(testDouble), "Log Double");

            ShowPreformance(() => Sin(testInt), "Sin Int");
            ShowPreformance(() => Sin(testLong), "Sin Long");
            ShowPreformance(() => Sin(testFloat), "Sin Float");
            ShowPreformance(() => Sin(testDouble), "Sin Double");

            //* Write a program to compare the performance of insertion sort, selection sort, quicksort for int, double and string values. Check also the following cases: random values, sorted values, values sorted in reversed order.

        }

        public static void ShowPreformance(Action method, string methodName)
        {
            Console.WriteLine(methodName + " Start At: ");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            method();
            timer.Stop();
            Console.WriteLine(methodName + " DONE: " + timer.Elapsed.TotalMilliseconds + "MS");
        }

        public static void Sum(dynamic number)
        {
            for (int i = 0; i < 100000; i++)
            {
                number += number;
            }
        }

        public static void Subtract(dynamic number)
        {
            for (int i = 0; i < 100000; i++)
            {
                number -= number;
            }
        }

        public static void Divide(dynamic number)
        {
            for (int i = 0; i < 20000; i++)
            {
                number /= number;
            }
        }

        public static void Multiply(dynamic number)
        {
            for (int i = 0; i < 20000; i++)
            {
                number *= number;
            }
        }

        public static void SQRT(dynamic number)
        {
            for (int i = 0; i < 20000; i++)
            {
                Math.Sqrt(number);
            }
        }

        public static void Log(dynamic number)
        {
            for (int i = 0; i < 20000; i++)
            {
                Math.Log(number);
            }
        }

        public static void Sin(dynamic number)
        {
            for (int i = 0; i < 20000; i++)
            {
                Math.Sin(number);
            }
        }
    }
}
