using System;
using System.Linq;

namespace Day_1___Variables_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string colors = "blue";

           Console.ForegroundColor = Cc(colors);

            dynamic words = "straight up";

            Console.WriteLine(words);

            //foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            //{
            //    if(colors == color.ToString().ToLower())
            //    {
            //        Console.ForegroundColor = color;
            //    }
                     
            //    //Console.WriteLine($"Foreground color set to {color}");
            //}

            string month = DateTime.Now.ToString("D");
            Console.WriteLine(month);
            Console.ResetColor();

            string name, city, ageString, pinString;
            byte age;
            int pin;

            // Step 1: Input
            // 1.1 Prompt User
            Console.Write("Enter Name: ");
            // 1.2 Get Input
            name = Console.ReadLine();

            // 1.1 Prompt User
            Console.Write("Enter City: ");
            // 1.2 Get Input
            city = Console.ReadLine();

            // 1.1 Prompt User
            Console.Write("Enter Age: ");
            // 1.2 Get Input
            ageString = Console.ReadLine();

            // 1.1 Prompt User
            Console.Write("Enter PIN: ");
            // 1.2 Get Input
            pinString = Console.ReadLine();

            // Step 2: Process Input
            age = byte.Parse(ageString);
            int birthYear = DateTime.Now.Year - age;

            pin = int.Parse(pinString);

            string formattedPin = String.Format("*****", pinString);
            string hiddenPin = new string('*', pinString.Length);


            // Step 3: Output
            Console.WriteLine("Your Name: {0}", name);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Age: " + age + " Birth Year: " +birthYear);
            Console.WriteLine("PIN: " + new string('*', pinString.Length));
            Console.WriteLine("PIN: " + formattedPin);
        }

        public static ConsoleColor Cc(string color)
        {
            return Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().Where(c => c.ToString().Contains(color, StringComparison.OrdinalIgnoreCase)).First();
        }
    }
}
