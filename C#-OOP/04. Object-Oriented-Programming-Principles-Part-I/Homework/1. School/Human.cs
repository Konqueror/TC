using System;

namespace School
{
    // We dont need to create Hummans so human will be abstract class.
    abstract class Human : IComment
    {
        // Every human has a name, so lets make a Field and a Property.
        private string name;
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
        
        public Human(string name)
        {
            this.Name = name;
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
