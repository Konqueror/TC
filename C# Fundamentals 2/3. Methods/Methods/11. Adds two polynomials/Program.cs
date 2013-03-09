//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:

using System;

class Program
{
    static void Main()
    {
        decimal[] polynomial1 = { 5, 0, 2,2,2 };
        Console.WriteLine("First polynomial:");
        PrintPolynomial(polynomial1);

        decimal[] polynomial2 = { 20, -5, -7 };
        Console.WriteLine("Second polynomial:");
        PrintPolynomial(polynomial2);

        Console.WriteLine("Second polynomial:");
        PrintPolynomial(AddPolynomial(polynomial1, polynomial2));
    }
    static void PrintPolynomial(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0 && i != 0)
            {
                if (polynomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} + ", i, polynomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynomial[i]);
            }
        }
        Console.WriteLine();
    }

    static decimal[] AddPolynomial(decimal[] polynomial1, decimal[] polynomial2)
    {
        decimal[] result = new decimal[Math.Max(polynomial1.Length, polynomial2.Length)];

        for (int i = 0; i < Math.Max(polynomial1.Length, polynomial2.Length); i++)
        {
            if (i > polynomial1.Length - 1)
            {
                result[i] = polynomial2[i];
            }
            else if (i > polynomial2.Length - 1)
            {
                result[i] = polynomial1[i];
            }
            else
            {
                result[i] = polynomial1[i] + polynomial2[i];
            }
        }
        return result;
    }

}

