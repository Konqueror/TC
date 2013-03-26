using System;

namespace _2.Person
{
    class IO
    {
        static void Main()
        {
            Person agedPerson = new Person("Ivan", 25);
            Person unagedPerson = new Person("Petur", null);

            Console.WriteLine(agedPerson);
            Console.WriteLine(unagedPerson);
        }
    }
}
