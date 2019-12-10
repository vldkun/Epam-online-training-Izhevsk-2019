using System;

namespace Module08
{
    /// <summary>
    /// Izh-08-2. Encapsulation. Inheritance. Polymorphism
    /// </summary>
    public class Rectangle : Figure
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double _width, double _height)
        {
            width = _width;
            height = _height;
        }

        public override double Area()
        {
            return height * width;
        }

        public override double Perimeter()
        {
            return 2 * (height + width);
        }
    }
}
