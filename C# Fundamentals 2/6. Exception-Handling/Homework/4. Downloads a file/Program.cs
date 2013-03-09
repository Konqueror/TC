//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class Program
{
    static void Main()
    {
        try
        {
            WebClient wc = new WebClient();
            wc.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "logo.jpg");
        }

        catch (WebException)
        {
            Console.Error.WriteLine("The address is invalid or there is no internet.");
        }

        catch (NotSupportedException)
        {
            Console.Error.WriteLine("Unknown error.");
        }
    }
}

