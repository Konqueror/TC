﻿//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\WINDOWS\win.ini";
            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: \n{0}:{1}", e.GetType().Name, e.Message);
            }

    }
}

