using System;

namespace Animals
{
    public enum Sex { Male, Female }

    abstract class Animal : ISound
    {
        private sbyte age;
        private string name;
        private Sex sex;

        public sbyte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

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

        public Sex Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        // Constructor
        public Animal(string name, sbyte age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        // Abstract method, you can access it. It have to be overriden
        abstract public string Sound();
    }
}
