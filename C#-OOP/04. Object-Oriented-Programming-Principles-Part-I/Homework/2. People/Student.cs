namespace People
{
    class Student : Human
    {
        private sbyte grade;

        public sbyte Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }
        // Constructor
        public Student(string firstName, string secondName, sbyte grade)
            :base(firstName, secondName)
        {
            this.Grade = grade;
        }

        // Override ToString for easy testing;
        public override string ToString()
        {
            return FirstName + " " + SecondName + " " + Grade;
        }
    }
}
