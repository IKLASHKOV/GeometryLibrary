using GeometryLibrary;

class Program
{
    static void Main()
    {
        try
        {
            double circleRadius = 5.0;
            double circleArea = GeometryCalculator.CalculateCircleArea(circleRadius);
            Console.WriteLine($"Площадь круга с радиусом {circleRadius}: {circleArea}");

            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            double triangleArea = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);
            Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB}, {sideC}: {triangleArea}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}