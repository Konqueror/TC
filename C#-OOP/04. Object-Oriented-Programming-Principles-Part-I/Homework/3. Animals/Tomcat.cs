namespace Animals
{
    class Tomcat : Cat
    {
        //Kittens can be only female and tomcats can be only male
        public Tomcat(string name, sbyte age)
            : base(name, age, Sex.Male)
        {
        }
        public override string Sound()
        {
            return "I am a Tomcat Mauuhahaha!.";
        }
    }
}
