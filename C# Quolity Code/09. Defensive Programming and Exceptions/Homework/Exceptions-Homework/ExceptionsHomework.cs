using System;
using System.Collections.Generic;
using System.Text;
//TODO: Refacture the code to separeted classes, but it is not the idea of the task here.
class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int length)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr", "Arr cannot be null.");
        }

        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("startIndex", "startIndex cannot be less than zero.");
        }

        if (startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException("startIndex", "startIndex cannot be larger than the array's length.");
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException("length", "length cannot be less than zero.");
        }

        if (startIndex > arr.Length - length)
        {
            throw new ArgumentOutOfRangeException("length", "index and length must refer to a location within the array.");
        }

        List<T> result = new List<T>();

        for (int i = startIndex; i < startIndex + length; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string text, int length)
    {
        if (text == null)
        {
            throw new ArgumentNullException("text", "text cannot be null.");
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException("length", "length cannot be less than zero.");
        }

        if (length > text.Length)
        {
            throw new ArgumentOutOfRangeException("length", "length cannot be greater then the string's lenght");
        }

        StringBuilder result = new StringBuilder();

        for (int i = text.Length - length; i < text.Length; i++)
        {
            result.Append(text[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor != 0)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        try
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));

            CheckPrime(23);



            CheckPrime(33);



            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
        
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}