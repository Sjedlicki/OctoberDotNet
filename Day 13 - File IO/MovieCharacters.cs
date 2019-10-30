using System;
using System.Collections.Generic;
using System.Text;

namespace Day_13___File_IO
{
    class MovieCharacters
    {
        public string Name { get; set; }
        public bool GoodBad { get; set; }
        public string Roll { get; set; }
        public int Age { get; set; }

        public MovieCharacters(string name, bool goodBad, string roll, int age)
        {
            Name = name;
            GoodBad = goodBad;
            Roll = roll;
            Age = age;
        }

    }
}
