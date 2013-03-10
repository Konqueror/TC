using System.Collections.Generic;

namespace School
{
    class Class
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string id;

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        // Constructor
        public Class(List<Student> students, List<Teacher> teachers, string id)
        {
            this.students = students;
            this.teachers = teachers;
            this.id = id;
        }
    }
}
