using System;

namespace Day_1___Variables
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C#.NET, 10/14/19, DE".Length);

            // Step 1: Input - Two numbers from User
            // Promt User Number 1
                    Console.Write("First Number: ");
                // Receive Input Number 1
                    string userNumber1 = Console.ReadLine();

                // Promt User Number 2
                    Console.Write("Second Number: ");
                // Receive Input Number 2
                    string userNumber2 = Console.ReadLine();

            // Step 2: Process Input - Adding numbers together
                // Parse string input into numerical value
                    int number1 = int.Parse(userNumber1);
                    int number2 = int.Parse(userNumber2);

                // Add converted numbers together
                int sum = number1 + number2;

            // Step 3: Output - Display the total
                Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
        }
    }
}
