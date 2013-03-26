﻿namespace Animals
{
    class Kitten : Cat
    {
        //Kittens can be only female and tomcats can be only male
        public Kitten(string name, sbyte age)
            : base(name, age, Sex.Female)
        {
        }

        public override string Sound()
        {
            return "I am a Kitten Miauuu!";
        }
    }
}
