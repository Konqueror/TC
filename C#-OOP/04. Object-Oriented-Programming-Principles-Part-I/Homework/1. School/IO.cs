//We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. 
//Classes have unique text identifier. Teachers have name. 
//Disciplines have name, number of lectures and number of exercises. 
//Both teachers and students are people. Students, classes, teachers and disciplines could have optional a(free text block).

//Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields,
//define the class hierarchy and create a class diagram with Visual Studio.

using School;
using System.Collections.Generic;

class IO
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("Ivan", 1));
        students.Add(new Student("Pesho", 2));
        students.Add(new Student("Gosho", 3));

        List<Discipline> disciplines = new List<Discipline>();
        disciplines.Add(new Discipline("Mathematics", 5, 3));
        disciplines.Add(new Discipline("Computers", 1, 2));

        List<Teacher> teachers = new List<Teacher>();
        teachers.Add(new Teacher("Daskala", disciplines));

        Class myClass = new Class(students, teachers, "Informatics");
        
        //Testing comments
        Student testingStudent = new Student("Misho", 1);
        testingStudent.AddComment("Random Comment for misho");
        System.Console.WriteLine(testingStudent.ShowComment());
    }
}

