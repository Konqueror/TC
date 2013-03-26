//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by 
//entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;

namespace InvalidRangeException
{
    class IO
    {
        static void Main()
        {
            try
            {
                int start = 1;
                int end = 100;

                int number = 123;

                if (number < start || number > end)
                {
                    throw new InvalidRangeException<int>(start, end);
                }

            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            // lets try it with DateTime objects
            try
            {
                DateTime start = new DateTime(1980, 1, 1);
                DateTime end = new DateTime(2013, 12, 31);

                DateTime randomDate = new DateTime(681, 1, 1);

                if (randomDate < start || randomDate > end)
                {
                    throw new InvalidRangeException<DateTime>(start, end);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
