namespace Animals
{
    class Dog : Animal
    {
        // Constructor
        public Dog(string name, sbyte age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override string Sound()
        {
            return "I am a dog BAU!";
        }
    }
}
