using System;
using Homework.Enums;
using System.Text;

namespace Homework
{
    class Student : ICloneable, IComparable<Student>
    {
        //Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
        //mobile phone e-mail, course, specialty, university, faculty.  Use an enumeration for the specialties, universities and faculties
        
        //Fields
        private string firstName;
        private string secondName;
        private string lastName;
        private int ssn;
        private string adress;
        private string phone;
        private string email;
        private string course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        // Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                this.secondName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int Ssn
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }

        public string Adress
        {
            get
            {
                return this.adress;
            }
            set
            {
                this.adress = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }

        // Constructor 
        public Student(string firstName, string secondName, string lastName, int ssn,
                        string adress, string phone, string email,
                        string course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Adress = adress;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }


        //Overrides
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.AppendFormat("{0} {1} {2} from {3}", this.FirstName, this.SecondName, this.LastName, this.University);
            //TODO: Display everything
            return result.ToString();
        }

        public override bool Equals(object otherStudent)
        {
            Student student = otherStudent as Student;

            if (student == null)
                return false;  

            if (!System.Object.Equals(this.ssn, student.ssn))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            //Why on Earth do I have to override this?!
            return base.GetHashCode();
        }

        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator != (Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        // 02. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into 
        //a new object of type Student.

        public object Clone()
        {
            //Make a new student like that
            Student newStudent = new Student(this.FirstName, this.SecondName, this.LastName, this.Ssn, this.Adress, 
                this.Phone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);

            return newStudent;
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName != otherStudent.FirstName)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }
            if (this.SecondName != otherStudent.SecondName)
            {
                return this.SecondName.CompareTo(otherStudent.SecondName);
            }
            if (this.LastName != otherStudent.LastName)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            if (this.Ssn != otherStudent.Ssn)
            {
                return this.Ssn.CompareTo(otherStudent.Ssn);
            }
            return 0;
        }
    }
}
