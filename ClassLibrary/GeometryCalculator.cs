using System;

namespace GeometryLibrary
{
    public static class GeometryCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            IsTriangle(sideA, sideB, sideC);
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public static bool IsRightAngledTriangle(double sideA, double sideB, double sideC)
        {
            IsTriangle(sideA, sideB, sideC);
            var sides = new double[] { sideA, sideB, sideC };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        private static void IsTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Длина сторон должны быть положительными числами.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Сумма любых двух сторон треугольника должна быть больше третьей стороны.");
            }
        }
    }
        

}


