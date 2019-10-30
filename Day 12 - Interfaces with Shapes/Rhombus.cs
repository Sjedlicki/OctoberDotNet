using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12___Interfaces_with_Shapes
{
    class Rhombus : IShape
    {
        public double TopLine { get; set; }
        public double BottomLine { get; set; }
        public double Height { get; set; }

        public Rhombus(double topLine, double bottomLine, double height)
        {
            TopLine = topLine;
            BottomLine = bottomLine;
            Height = height;
        }

        public Rhombus() 
        {
            TopLine = 1;
            BottomLine = 1;
            Height = 1;
        }

        public double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculateTheOutSide()
        {
            throw new NotImplementedException();
        }

        public double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
