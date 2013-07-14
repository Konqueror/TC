using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Course
    {
        public const int MaxNumberOfStudents = 30;

        private string name;
        private List<Student> studentsList;

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public List<Student> StudentsList
        {
            get
            {
                return this.studentsList;
            }

            protected set
            {
                this.studentsList = value;
            }
        }

        public Course(string name)
        {
            this.Name = name;
            this.StudentsList = new List<Student>();
        }

        public void Join(Student student)
        {
            if (this.StudentFound(student))
            {
                throw new ArgumentException("This student has already joined this course!");
            }
            else if (this.StudentsList.Count >= MaxNumberOfStudents)
            {
                throw new ArgumentOutOfRangeException("The course is full!");
            }
            else
            {
                this.StudentsList.Add(student);
            }
        }

        public void Leave(Student student)
        {
            if (this.StudentFound(student))
            {
                this.StudentsList.Remove(student);
            }
            else
            {
                throw new ArgumentException("Student not found!");
            }
        }

        private bool StudentFound(Student student)
        {
            for (int i = 0; i < this.StudentsList.Count; i++)
            {
                if (student.Id == this.StudentsList[i].Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
