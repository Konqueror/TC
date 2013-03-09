using System;

namespace Version
{
    //Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a 
    //version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.

    [Version("2.11")]

    class IO
    {
        public static void Main()
        {
            object[] version = typeof(IO).GetCustomAttributes(typeof(Version), false);

            Console.WriteLine("Version: {0}", version[0]);
        }
    }
}
