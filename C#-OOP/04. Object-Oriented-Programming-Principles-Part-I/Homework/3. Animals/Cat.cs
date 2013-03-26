namespace Animals
{
    class Cat : Animal, ISound
    {
        // Constructor
        public Cat(string name, sbyte age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override string Sound()
        {
            return "I am just a cat! Miaulch";
        }
    }
}
