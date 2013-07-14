using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Student
    {
        private string name;
        private int id;
       
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The student ID must be in the range [10000, 99999]!");
                } 
            }
        }

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
