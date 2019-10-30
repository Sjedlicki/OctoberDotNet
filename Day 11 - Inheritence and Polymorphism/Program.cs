using System;
using System.Collections.Generic;

namespace Day_11___Inheritence_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Badger");


            Dog doggo = new Dog("Peanut", 17);
            Dog dogoo = new Dog("Rover", 10);
            Dog dog = new Dog("Odie", 2);

            Cat catto = new Cat("Whiskers", 22);
            Cat cat = new Cat("Mr. Bigglesworth", 18);
            Cat catoo = new Cat("Soo", 16);     

            List<Animal> animalList = new List<Animal> { animal, doggo, dog, dogoo, cat, catto, catoo };

            foreach(Animal ani in animalList)
            {
                if(ani is Cat)
                {
                    Cat c = (Cat)ani;
                    c.AddHoursSlept();
                    Console.WriteLine(c.HoursSlept);
                    c.MakeSound();
                }
                else if (ani is Dog)
                {
                    Dog d = (Dog)ani;
                    d.FetchAStick();
                    Console.WriteLine(d.SticksFetched);
                    d.MakeSound();
                }
                else
                {
                    animal.MakeSound();
                }
            }        
        }
    }
}
