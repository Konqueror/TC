using System;
using System.Threading;
class Program
{
    static void Main()
    {
        int option = SelectFunction();
        Console.Clear();
        if (option == 1)
            ReversesDigits();
        if (option == 2)
            GetAverage();
        if (option == 3)
            Linear();
       

    }
    static int SelectFunction()
    {
        Console.WriteLine("Type a number from 1 to 3:");
        Console.WriteLine("1) Reverses the digits of a number");
        Console.WriteLine("2) Calculates the average of a sequence of integers");
        Console.WriteLine("3) Solves a linear equation a * x + b = 0");
                
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.D1) { return 1; }
            if (keyInfo.Key == ConsoleKey.D2) { return 2; }
            if (keyInfo.Key == ConsoleKey.D3) { return 3; }
            Thread.Sleep(300);
        }
    }
    static void ReversesDigits()
    {
        string strNum;
        int n;
        do
        {
            Console.Write("Enther an intiger: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number

        Console.Write("Reversed: ");
        int result = 0;
        while (n != 0)
        {
            result = result + n % 10;
            n = n / 10;
            result = result * 10;
        }
        Console.WriteLine(result/10);
    }

    static void GetAverage()
    {
        string strNum;
        int sum = 0;
        int number = 0;
        int n;
        do
        {
            Console.Write("How many intiger do you want to sume: ");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number

        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write("Enter the {0}th number: ", i + 1);
            }
            while (!int.TryParse(strNum = Console.ReadLine(), out number)); // check if it is a real number
            sum = sum + number;
        }

        Console.WriteLine("The the average of a sequence  is: {0}", sum / number);
    }

    static void Linear()
    {
        Console.WriteLine("a * x + b = 0");
        string strNum;
        double a;
        do
        {
            Console.Write("Enter a (a != 0): ");
        }
        while (!double.TryParse(strNum = Console.ReadLine(), out a) || a == 0); // check if it is a real number

        double b;
        do
        {
            Console.Write("Enter b: ");
        }
        while (!double.TryParse(strNum = Console.ReadLine(), out b)); // check if it is a real number
        Console.WriteLine("{0} * x + {1} = 0",a,b);
        double result = (-1 * b)/a;
        Console.WriteLine("x = {0}", result);
    }
}

