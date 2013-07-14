using System;
using System.Collections.Generic;

namespace Longest_Subsequence
{
    public class Program
    {
        public static void Main()
        {
            string[] elements = { "1", "1", "2", "3", "3", "3", "3", "3", "2", "2", "1", "1", };

            List<int> sequence = new List<int>();
            foreach (string element in elements)
            {
                sequence.Add(int.Parse(element));
            }

            Console.WriteLine(String.Join(" ", GetLongesSeq(sequence)));
        }

        public static List<int> GetLongesSeq(List<int> sequence)
        {

            int currentCount = 1;
            int currentStartIndex = 0;
            int longestCount = 1;
            int longestStartIndex = 0;

            while (currentStartIndex < sequence.Count - 1)
            {
                while ((currentStartIndex + currentCount < sequence.Count) &&
                    (sequence[currentStartIndex] == sequence[currentStartIndex + currentCount]))
                {
                    currentCount++;
                }

                if (currentCount > longestCount)
                {
                    longestCount = currentCount;
                    longestStartIndex = currentStartIndex;
                }

                currentCount = 1;
                currentStartIndex += currentCount;
            }

            return sequence.GetRange(longestStartIndex, longestCount);
        }
    }
}