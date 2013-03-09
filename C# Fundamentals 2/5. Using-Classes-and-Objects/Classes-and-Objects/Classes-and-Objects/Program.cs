//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class Program
{
    static void Main()
    {
        string strNum;
        short year;
        do
        {
            Console.Write("Enter a year: ");
        }
        while (!short.TryParse(strNum = Console.ReadLine(), out year) || year > 9999 || year < 1); // check if it is a real number

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is Leap!", year);
        }
        else
        {
            Console.WriteLine("{0} is NOT Leap!", year);
        }
    }
}

