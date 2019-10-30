using System;

namespace Lab_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {


            string greeting = "Enter a number between 1 and 100: ";

            int userNumber = 1;

            bool repeat = true;
            while (repeat)
            {
                Console.Write(greeting);

                while (!int.TryParse(Console.ReadLine(), out userNumber))
                {
                    Console.Beep(); Console.Beep(); Console.Beep();
                    Console.WriteLine("Ah ah ah, you didn't say the magic word!");
                    Console.Write(greeting);
                }

                if (userNumber > 0 && userNumber <= 100)
                {
                    if (userNumber % 2 != 0)
                    {
                        if (userNumber < 60)
                        {
                            Console.WriteLine($"Odd and less than 60");
                        }
                        else
                        {
                            Console.WriteLine($"{userNumber} and Odd");
                        }
                    }
                    else
                    {
                        if (userNumber >= 2 && userNumber <= 25)
                        {
                            Console.WriteLine("Even and less than 25");
                        }
                        else if (userNumber >= 26 && userNumber <= 60)
                        {
                            Console.WriteLine($"Even");
                        }
                        else
                        {
                            Console.WriteLine($"{userNumber} and Even");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Number out of range!");
                }

                Console.WriteLine("Press any key to continue");
                Console.WriteLine("Press esc to exit.");


                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

                Console.Clear();
            }
        }


        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }


        //public static RGBColor FromRainbow(Rainbow colorBand) =>
        //    colorBand switch
        //    {
        //        Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
        //         Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
        //         Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
        //        Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
        //         Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
        //        Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
        //         Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
        //          _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
        //    };
    }
}
