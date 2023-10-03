namespace Week5InClassDemo
{
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
}
