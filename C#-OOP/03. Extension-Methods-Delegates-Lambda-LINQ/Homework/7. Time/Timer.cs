//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Threading;

class Timer
{
    delegate void myTimer(int t);

    static void Main()
    {
        myTimer timer = delegate(int time)
        {
            while (true)
	        {
	            Thread.Sleep(time);
                Console.WriteLine("Action!");
	        }
        };

        timer(800);
    }
}