using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class GeometryCalculatorTests
    {
        [TestMethod]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5.0;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            double area = GeometryCalculator.CalculateCircleArea(radius);

            Assert.AreEqual(expectedArea, area, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateCircleArea_NegativeRadius_ThrowsArgumentException()
        {
            GeometryCalculator.CalculateCircleArea(-1.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateCircleArea_ZeroRadius_ThrowsArgumentException()
        {
            GeometryCalculator.CalculateCircleArea(0);
        }

        [TestMethod]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            double expectedArea = 6.0; 

            double area = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);

            Assert.AreEqual(expectedArea, area, 0.001); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTriangleArea_InvalidSides_ThrowsArgumentException()
        {
            double sideA = 1.0;
            double sideB = 2.0;
            double sideC = 3.0; 

            GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTriangleArea_NegativeSide_ThrowsArgumentException()
        {
            double sideA = 3.0;
            double sideB = -4.0;
            double sideC = 5.0;

            GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTriangleArea_ZeroSide_ThrowsArgumentException()
        {
            double sideA = 3.0;
            double sideB = 0.0;
            double sideC = 5.0;

            GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);
        }
        [TestMethod]
        public void IsRightAngledTriangle_ValidRightTriangle_ReturnsTrue()
        {
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;

            bool IsRightAngledTriangle = GeometryCalculator.IsRightAngledTriangle(sideA, sideB, sideC);

            Assert.IsTrue(IsRightAngledTriangle);
        }

        [TestMethod]
        public void IsRightAngledTriangle_ValidNonRightTriangle_ReturnsFalse()
        {
            double sideA = 2.0;
            double sideB = 2.0;
            double sideC = 3.0;

            bool IsRightAngledTriangle = GeometryCalculator.IsRightAngledTriangle(sideA, sideB, sideC);

            Assert.IsFalse(IsRightAngledTriangle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsRightAngledTriangle_NegativeSide_ThrowsArgumentException()
        {
            GeometryCalculator.IsRightAngledTriangle(3.0, -4.0, 5.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsRightAngledTriangle_ZeroSide_ThrowsArgumentException()
        {
            GeometryCalculator.IsRightAngledTriangle(3.0, 0.0, 5.0);
        }
    }
}
