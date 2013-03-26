using System;

namespace _3.BitArray64
{
    class IO
    {
        static void Main()
        {
            BitArray64 testNumber = new BitArray64(100);
            BitArray64 testNumber2 = new BitArray64(100);
            
            Console.WriteLine(testNumber.Equals(testNumber2));

            Console.WriteLine(testNumber[2]);
        }
    }
}
