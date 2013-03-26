namespace Animals
{
    class Frog : Animal
    {
        public Frog(string name, sbyte age, Sex sex)
            : base(name, age, sex)
        {
        }

        override public string Sound()
        {
            return "I am a Frog Ruaba!";
        }
    }
}
