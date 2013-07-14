using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course name can't be null or empty.");
                }
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return new ReadOnlyCollection<string>(this.students);
            }
            set
            {
                this.students = value;
            }
        }
            
        protected Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public void AddStudent(string student)
        {
            if (this.students == null)
            {
                this.students = new List<string>();
            }

            this.students.Add(student);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name = {0}; ", this.Name);

            if (this.TeacherName != null)
            {
                result.AppendFormat("Teacher = {0}; ", this.TeacherName);
            }

            result.AppendFormat("Students = {0}", this.GetStudentsAsString());

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.students == null || this.students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.students) + " }";
            }
        }

    }
}
