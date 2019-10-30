using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_9___Classes_Animals_Eample
{
    class Animal
    {
        static List<Animal> animalList = new List<Animal>
            {
                new Animal("Whiskers", "Cat", "Meow", true),
                new Animal("Scorsese", "Dog", "Woof", true),
                new Animal("William Snakespeare", "Snake", "Hiss", false),
                new Animal("Nemo", "Fish", "Dad", false),
                new Animal("Ron", "Rhino", "Bellow", false),
                new Animal("Fluffly", "Bear", "Rawr", true),
                new Animal("Nermal", "Cat", "Meow", true),
                new Animal("Fido", "Dog", "Woof", true)
            };
        #region Fields
        private string name;
        private string type;
        private string sound;
        private bool fur;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public bool Fur
        {
            get { return fur; }
            set { fur = value; }
        }
        #endregion

        public Animal() { }
        public Animal(string _name, string _type, string _sound, bool _fur)
        {
            name = _name;
            type = _type;
            sound = _sound;
            fur = _fur;
        }

        public static List<Animal> GetAnimalTypes(string userSelection)
        {
            List<Animal> animalTypes = new List<Animal>();

            foreach (Animal animal in animalList)
            {
                if (animal.Type.ToLower().Contains(userSelection.ToLower()))
                {
                    animalTypes.Add(animal);
                }
            }

            return animalTypes;
        }

        public static void DisplayAnimalTypes()
        {
            foreach(Animal animal in animalList)
            {
                Console.WriteLine(animal.Type);
            }
        }
    }
}
