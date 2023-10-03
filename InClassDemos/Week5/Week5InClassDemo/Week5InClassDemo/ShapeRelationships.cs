using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassDemo
{
    internal class ShapeRelationships
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            Rectangle r = new Rectangle();

           // Shape ss = new Shape();
        }
    }


    public abstract class Shape
    {
        public string Color { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public Shape(int length, int width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public Shape()
        {

        }


        public abstract int CalculateArea();
    }

    public class Square : Shape
    {
        public override int CalculateArea()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Shape
    { 

        public override int CalculateArea()
        {
            return Length * Width;
        }
    }
}
