using System;
using Homework.Enums;

namespace Homework
{
    class IO
    {
        static void Main()
        {
            Student studentOne = new Student("Ivan", "Ivanov", "Curev", 880008, "Bulgaria, Sofia", "088894857",
                                             "VankataSex@gmail.com", "third", Specialty.Informatics, University.SU, Faculty.FMI);

            Student studentTwo = new Student("Petur", "Ivanov", "Curev", 880008, "Bulgaria, Sofia", "088894857",
                                             "VankataSex@gmail.com", "third", Specialty.Informatics, University.SU, Faculty.FMI);



            Console.WriteLine(studentOne);
            Console.WriteLine(studentOne.GetHashCode());
            Console.WriteLine(studentOne == studentTwo);

            object studentOneClone = studentOne.Clone();
            Console.WriteLine(studentOneClone.GetHashCode());
            Console.WriteLine(studentOneClone);

        }
    }
}
