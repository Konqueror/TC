using School;
using System.Collections.Generic;

class IO
{
    public static void Main()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("apple", 1);
        dictionary.Add("te", 1);

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
    }
}

