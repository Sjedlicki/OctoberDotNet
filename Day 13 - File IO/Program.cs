using System;
using System.Collections.Generic;
using System.IO;

namespace Day_13___File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();

            //StreamReader reader = new StreamReader("../../../Students.txt");
            //string line = reader.ReadLine();
            //while(line != null)
            //{
            //    names.Add(line);
            //    line = reader.ReadLine();
            //}
            //reader.Close();

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //names.Add("Harry Potter");

            //StreamWriter writer = new StreamWriter("../../../Students.txt");

            //foreach(string name in names)
            //{
            //    writer.WriteLine(name);
            //}         
            //writer.Close();

            //List<MovieCharacters> characters = new List<MovieCharacters>
            //{
            //    new MovieCharacters("Columbus", true, "Lead", 23),
            //    new MovieCharacters("Ruby Rose", true, "Lead", 17),
            //    new MovieCharacters("Jack Skellington", true, "Lead", 99),
            //    new MovieCharacters("Joker", false, "Lead", 30),
            //    new MovieCharacters("Doug \"The Thug\" Glatt", false, "Lead", 30),
            //    new MovieCharacters("John Rambo", true, "Lead", 75),
            //    new MovieCharacters("Lieutenant Dan", true, "Supporting Actor", 45),
            //    new MovieCharacters("Samwise Gamgee", true, "The Real MVP", 102),
            //};

            //FileStream streamer = File.Create("../../../MovieCharacters.txt");


            //StreamWriter writer = new StreamWriter("../../../MovieCharacters.txt");

            //foreach (MovieCharacters character in characters)
            //{
            //    writer.WriteLine($"{character.Name}|{character.GoodBad}|{character.Roll}|{character.Age}");
            //}
            //writer.Close();

            List<MovieCharacters> characters = new List<MovieCharacters>();

            StreamReader reader = new StreamReader("../../../MovieCharacters.txt");
            string line = reader.ReadLine();

            while(line != null)
            {
                string[] word = line.Split('|');
                characters.Add(new MovieCharacters(word[0], bool.Parse(word[1]), word[2], int.Parse(word[3])));
                line = reader.ReadLine();
            }
            reader.Close();

            foreach(MovieCharacters character in characters)
            {
                Console.WriteLine(character.Name);
            }
        }
    }
}
