using System;

namespace School
{
    class Student : Human
    {
        // A ClassNumber for every Student
        private byte number;

        public byte Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public Student(string name, byte number)
        : base(name)
        {
            this.Number = number;
        }

    }
}
