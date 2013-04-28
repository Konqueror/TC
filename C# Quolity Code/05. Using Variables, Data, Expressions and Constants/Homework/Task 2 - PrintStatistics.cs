using System;

class Refactoring
{
    public void PrintStatistics(double[] information)
    {
        Console.WriteLine("The Maximal number is: " + GetMaxNumber(information));
        Console.WriteLine("The Minimal number is: " + GetMinNumber(information));
        Console.WriteLine("The Avarage number is: " + GetAvarageNumber(information));
    }

    public double GetMaxNumber(double[] information)
    {
        double maxNumber = information[0];
        for (int i = 0; i < information.Length; i++)
        {
            if (information[i] > maxNumber)
            {
                maxNumber = information[i];
            }
        }
        return maxNumber;
    }

    private double FindMinNumber(double[] information)
    {
        double minNumber = information[0];
        for (int i = 0; i < information.Length; i++)
        {
            if (information[i] < minNumber)
            {
                minNumber = information[i];
            }
        }
        return minNumber;
    }

    private double FindAvarage(double[] information)
    {
        double sum = 0;
        for (int i = 0; i < information.Length; i++)
        {
            sum += information[i];
        }
        double avarage = sum / numbers.Length;
        
        return avarage;
    }
}