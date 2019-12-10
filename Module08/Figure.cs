using System;

namespace Module08
{
    /// <summary>
    /// Izh-08-2. Encapsulation. Inheritance. Polymorphism
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Calculation area of a figure.
        /// </summary>
        /// <returns>Returns area of this figure.</returns>
        public abstract double Area();
        /// <summary>
        /// Calculation perimeter of a figure.
        /// </summary>
        /// <returns>Returns perimeter of this figure.</returns>
        public abstract double Perimeter();
    }
}
