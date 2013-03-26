using System;
using System.Linq;
using System.Collections.Generic;

namespace People
{
    class IO
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 10),
                new Student("Petur", "Petrov", 9),
                new Student("Georgi", "Georgiev", 11),
                new Student("Monika", "Petrova", 12),
                new Student("Simona", "Ivanova", 10),
                new Student("Cecka", "Ceckova", 8),
                new Student("Maria", "Ivanova", 9),
                new Student("Petur", "Peichinov", 3),
            };

            //sort them by grade in ascending order use LINQ 
            var sortedStudents =
                from student in studentsList
                orderby student.Grade
                select student;

            Console.WriteLine("Show ordered students:");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student); // ToString is overrwriten!
            }

            List<Worker> workersList = new List<Worker>()
            {
                new Worker("Ivan", "Ivanov", 200, 8),
                new Worker("Petur", "Petrov", 250, 8),
                new Worker("Georgi", "Georgiev", 180, 5),
                new Worker("Monika", "Petrova", 80, 1),
                new Worker("Simona", "Ivanova", 2000, 5),
                new Worker("Cecka", "Ceckova", 2500, 10),
                new Worker("Maria", "Ivanova", 800, 6),
                new Worker("Petur", "Peichinov", 900, 8),
            };

            var sortedWorkers =
                from worker in workersList
                orderby worker.MoneyPerHour() descending
                select worker;

            Console.WriteLine("\nShow ordered workers:");
            
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker); // ToString is overrwriten!
            }

            //Lets Merge and sort them
            var mergedList = from human in workersList.Concat<Human>(studentsList)
                             orderby human.FirstName, human.SecondName
                             select human;
            

            Console.WriteLine();
            foreach (var human in mergedList)
            {
                Console.WriteLine(human);
            }
        }
    }
}
