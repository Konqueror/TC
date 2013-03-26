//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
//Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of 
//animal using a static method (you may use LINQ).
using System;

namespace Animals
{
    class IO
    {
        public static void Main()
        {
            Animal[] dogsList =
            {
                new Dog("Rio", 5, Sex.Female),
                new Dog("Barry", 3, Sex.Female),
                new Dog("Smotan", 2, Sex.Female),
                new Dog("Pes", 6, Sex.Female),
                new Cat("Maca", 2, Sex.Female),
                new Frog("Jabko", 30, Sex.Female)
            };

            //Lets here their sonds
            for (int i = 0; i < dogsList.Length; i++)
            {
                Console.WriteLine(dogsList[i].Sound());
            }

            Console.WriteLine("The Average age of all animals is: " + AverageAge(dogsList));
        }

        static double AverageAge(Animal[] animalList)
        {
            double average = 0;

            foreach (var animal in animalList)
            {
                average += animal.Age;
                //average = average + animal.Age;
            }

            return average / animalList.Length;
        }
    }
}
