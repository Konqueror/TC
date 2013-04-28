using System;

class MainClass
{
    const int MaxCount = 6; //TODO: implement something with this

    public static void Main()
    {
        var printer = new MainClass.PrintMethods();
        printer.PrintArgumentOnConsole(true);
    }

    class PrintMethods
    {
        void PrintArgumentOnConsole(bool boolToPrint)
        {
            string bolleanAsString = boolToPrint.ToString();
            Console.WriteLine(bolleanAsString);
        }
    }
}
