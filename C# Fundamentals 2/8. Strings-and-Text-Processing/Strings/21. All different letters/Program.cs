//Write a program that reads a string from the console and prints all different letters in the string along with 
//information how many times each letter is found. 

using System;

class Program
{
    static void Main()
    {
        int counter = 0;
        string text = Console.ReadLine();
        for (int i = 33; i <= 126; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if ((char)i == text[j])
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine("{0}: {1} times", (char)i, counter);
            }
            counter = 0;
        }

    }
}

