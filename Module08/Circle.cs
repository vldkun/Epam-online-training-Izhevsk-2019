using System;

namespace Module08
{
    /// <summary>
    /// Izh-08-2. Encapsulation. Inheritance. Polymorphism
    /// </summary>
    public class Circle : Figure
    {
        private readonly double radius;

        public Circle(double _radius)
        {
            radius = _radius;
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
