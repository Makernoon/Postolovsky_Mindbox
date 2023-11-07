using System;
using Xunit;

namespace Shapes.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = circle.CalculateArea();

            double expectedArea = Math.PI * radius * radius;
            Assert.Equal(expectedArea, area);
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            double expectedArea = 6;
            Assert.Equal(expectedArea, area);
        }

        [Fact]
        public void IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.True(isRightAngled);
        }

        [Fact]
        public void IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.False(isRightAngled);
        }
    }
}