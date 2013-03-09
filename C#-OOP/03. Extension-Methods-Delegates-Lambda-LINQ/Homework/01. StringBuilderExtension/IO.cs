using System;
using System.Text;
namespace _01.StringBuilderExtension
{
    class IO
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.Append("My name is Ninja");
            StringBuilder result = text.Substring(11, 5);

            Console.WriteLine(result);
        }
    }
}
