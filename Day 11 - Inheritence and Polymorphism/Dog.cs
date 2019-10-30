using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11___Inheritence_and_Polymorphism
{
    class Dog : Animal
    {
        public int SticksFetched { get; set; }
        public Dog(string name, int sticksFetched) : base(name)
        {
            SticksFetched = sticksFetched;
        }

        public Dog(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says \"Woof\"!");
        }

        public void FetchAStick()
        {
            SticksFetched++;
        }
    }
}
