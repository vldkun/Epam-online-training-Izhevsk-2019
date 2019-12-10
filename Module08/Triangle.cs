using System;

namespace Module08
{
    /// <summary>
    /// Izh-08-2. Encapsulation. Inheritance. Polymorphism
    /// </summary>
    class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double _side1, double _side2, double _side3)
        {
            side1 = _side1;
            side2 = _side2;
            side3 = _side3;
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public override double Area()
        {
            double halfPerimeter = Perimeter() / 2;
            return Math.Sqrt(
                halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        }
    }
}
