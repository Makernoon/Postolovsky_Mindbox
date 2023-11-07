using System;
using Shapes.Interfaces;

namespace Shapes
{
    public class Circle: IShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
