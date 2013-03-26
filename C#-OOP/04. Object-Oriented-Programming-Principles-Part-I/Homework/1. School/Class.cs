using System.Collections.Generic;

namespace School
{
    class Class
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string id;
        private string comment;

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            //Check for unique id
            set
            {
                bool foundDuplicated = false;
                for (int i = 0; i < value.Count; i++)
                {
                    for (int j = i + 1; j < value.Count; j++)
                    {
                        if (value[i].Number == value[j].Number)
                        {
                            foundDuplicated = true;
                            break;
                        }
                       
                    }
                    if (foundDuplicated == true)
                    {
                        break;
                    }
                }

                if (foundDuplicated == true)
                {
                    throw new System.ArgumentException("Student id have to be unique");
                }
                else
                {
                    this.students = value;
                }
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
            this.Students = students;
            this.teachers = teachers;
            this.Id = id;
        }

        public void AddComment(string comment)
        {
            this.comment = comment;
        }
        public string ShowComment()
        {
            return this.comment;
        }
    }
}
