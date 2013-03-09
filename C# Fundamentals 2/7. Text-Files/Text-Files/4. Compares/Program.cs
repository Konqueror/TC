//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader readerOne = new StreamReader("../../File1.txt"), readerTwo = new StreamReader("../../File2.txt"))
        {
            string lines1, lines2;
            int different = 0;
            int same = 0;

            while ((lines1 = readerOne.ReadLine()) != null && (lines2 = readerTwo.ReadLine()) != null)
            {
                if (lines1 == lines2) same++;
                else different++;
            }

            Console.WriteLine("{0} different lines \n{1} same lines", different, same);
        }   
    }
}

