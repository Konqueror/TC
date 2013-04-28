using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
class Program
{
    static StringBuilder output = new StringBuilder();

    static class Messages
    {
        public static void EventAdded()
        { 
            output.Append("Event added\n"); 
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound() 
        { 
            output.Append("No events found\n"); 
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }
    static EventHolder events = new EventHolder();

    static void Main(string[] args)
    {
        ExecuteNextCommand();
        Console.WriteLine(output);
    }

    private static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();

        if (command[0] == 'A') 
        { 
            AddEvent(command); 
            return true; 
        }

        if (command[0] == 'D') 
        { 
            DeleteEvents(command); 
            return true; 
        }

        if (command[0] == 'L') 
        { 
            ListEvents(command); 
            return true; 
        }

        if (command[0] == 'E') 
        { 
            return false; 
        }

        return false;
    }
}

