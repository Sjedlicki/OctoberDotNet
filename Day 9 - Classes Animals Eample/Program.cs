using System;
using System.Collections.Generic;

namespace Day_9___Classes_Animals_Eample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take in input from the user that allows the user to choose which animals
            // they would like to be show on the console.

            Animal.DisplayAnimalTypes();

            Console.WriteLine("What kind of animal would you like to see?");
            string userInput = Console.ReadLine();

            List<Animal> animalTypes = Animal.GetAnimalTypes(userInput);

            for(int i = 0;  i < animalTypes.Count; i++)
            {
                Console.WriteLine($"{animalTypes[i].Name} is a {animalTypes[i].Type} and goes {animalTypes[i].Sound}");
            }
        }
    }
}