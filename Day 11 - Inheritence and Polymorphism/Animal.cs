using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11___Inheritence_and_Polymorphism
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("I make sounds");
        }
    }
}
