using System;

namespace School
{
    class Discipline : IComment
    {
        private string name;
        private int lectures;
        private int exercises;
        private string comment;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }
            set
            {
                this.lectures = value;
            }
        }

        public int Exercises
        {
            get
            {
                return this.exercises;
            }
            set
            {
                this.exercises = value;
            }
        }
        // Constructor
        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
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
