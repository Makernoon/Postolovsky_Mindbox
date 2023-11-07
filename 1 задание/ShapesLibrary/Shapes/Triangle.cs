using System;
using Shapes.Interfaces;

namespace Shapes
{
    public class Triangle: IShape
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public bool IsRightAngled()
        {
            return (sideA * sideA + sideB * sideB == sideC * sideC) ||
                (sideA * sideA + sideC * sideC == sideB * sideB) ||
                (sideB * sideB + sideC * sideC == sideA * sideA);
        }
    }
}
