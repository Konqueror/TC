using System;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public DateTime BirthDate { get; set; }
    public string Hobby { get; set; }


    public Student(string firstName, string lastName, string city, DateTime birthDate)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.City = city;
        this.BirthDate = birthDate;
    }
    
    public Student(string firstName, string lastName, string city, DateTime birthDate, string hobby)
        : this(firstName, lastName, city, birthDate)
    {
        this.Hobby = hobby;
    }

    public bool IsOlderThan(Student otherStudent)
    {
        DateTime firstStudent = this.BirthDate;
        DateTime secondStudent = otherStudent.BirthDate;

        bool isOlder = false;
        if (DateTime.Compare(firstStudent, secondStudent) < 0)
        {
            isOlder = true;
        }

        return isOlder;
    }


}
