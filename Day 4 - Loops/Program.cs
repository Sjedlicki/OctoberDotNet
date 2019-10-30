using System;
using System.Text;

namespace Day_4___Loops
{
    class Program
    {
        private int _myInt;
        public int MyInt { get; set; }
        private static Random random
        {
            get
            {
                return new Random();
            }
        }

        private static ConsoleColor RandomColor
        {
            get
            {
                Enum.TryParse(random.Next(1, 16).ToString(), out ConsoleColor color);
                return color;
            }
        }
        static void Main(string[] args)
        {
            string message = "Mlem doing me a frighten dat tungg tho pupperino pupper boof long doggo smol borking doggo with a long snoot for pats, doggo puggorino doge shoob long woofer fluffer. Shooberino noodle horse maximum borkdrive borkf ruff very jealous pupper doggorino, smol borking doggo with a long snoot for pats noodle horse smol adorable doggo. Super chub noodle horse very taste wow you are doing me a frighten heckin good boys shooberino, bork the neighborhood pupper very hand that feed shibe stop it fren. Length boy shibe shooberino tungg, shibe. wow very biscit.  Shibe wow very biscit heckin angery woofer long water shoob fluffer, h*ck smol. Heckin angery woofer borking doggo most angery pupper I have ever seen you are doing me a frighten stop it fren fat boi heckin angery woofer many pats, long doggo much ruin diet floofs you are doing me the shock lotsa pats aqua doggo. Many pats pupper long water shoob pupper dat tungg tho, borkf snoot doggo you are doing me the shock, ruff wow such tempt doggorino.";

            string[] words = ConvertStringToArray(message);

            //SayHello("Word Up", 5);
            //Console.Write("Enter Name: ");
            //PrintName(Console.ReadLine(), 10);

            // PrintOddNUmbers(300);
            // Console.WriteLine(ContAllTheNumbers(5));
            // int count = CountAs("Hello To the world the steve is dead, you may barbeque his head!! But what about his body, they flushed it down the potty");
            //Console.WriteLine($"{count}".PadRight(10, '*'));

            //PrintInColor(message);
            PrintInColor(words);
        }

        public static string[] ConvertStringToArray(string message)
        {
            return message.Split(' ');
        }

        public static void PrintInColor(string message)
        {

            foreach (char c in message)
            {
                Console.ForegroundColor = RandomColor;
                Console.Write(c);
            }
            Console.ResetColor();
        }

        public static void PrintInColor(string[] message)
        {
            foreach (string s in message)
            {
                Console.ForegroundColor = RandomColor;
                Console.Write($"{s} ");
            }
            Console.ResetColor();
        }

        public static int CountAs(string param)
        {
            int count = 0;
            foreach (char c in param)
            {
                if (c == 'a')
                {
                    count++;
                }
            }
            return count;
        }

        public static int ContAllTheNumbers(int number)
        {
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static void SayHello(string message, int number)
        {
            while (number != 0)
            {
                Console.WriteLine($"{number}: {message}");
                number--;
            }
        }

        public static void PrintName(string userName, int number)
        {
            do
            {
                Console.WriteLine($"Hello, {userName}!");
                number--;
            } while (number > 0);
        }

        public static void PrintOddNUmbers(int number)
        {
            for (int i = number; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
