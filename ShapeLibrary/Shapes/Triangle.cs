using ShapeLibrary.Shapes.Abstractions;

namespace ShapeLibrary.Shapes;

/// <summary>
/// Представляет треугольник с тремя сторонами.
/// </summary>
/// <remarks>
/// Класс предоставляет методы для вычисления площади и проверки, является ли треугольник прямоугольным.
/// </remarks>
public class Triangle : IShape, ITriangle
{
    /// <summary>
    /// Длина стороны A треугольника.
    /// </summary>
    public double SideA { get; }

    /// <summary>
    /// Длина стороны B треугольника.
    /// </summary>
    public double SideB { get; }

    /// <summary>
    /// Длина стороны C треугольника.
    /// </summary>
    public double SideC { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Triangle"/> с заданными длинами сторон.
    /// </summary>
    /// <param name="sideA">Длина стороны A (должна быть положительной).</param>
    /// <param name="sideB">Длина стороны B (должна быть положительной).</param>
    /// <param name="sideC">Длина стороны C (должна быть положительной).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если стороны не образуют допустимый треугольник или если их значения неположительные.</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Все стороны должны иметь положительную длинну");

        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("Треугольника с заданными сторонами не существует");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    /// Создает копию существующего треугольника.
    /// </summary>
    /// <param name="triangle">Экземпляр треугольника для копирования.</param>
    public Triangle(Triangle triangle)
    {
        SideA = triangle.SideA;
        SideB = triangle.SideB;
        SideC = triangle.SideC;
    }

    public double GetArea()
    {
        // Heron's formula
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    /// <summary>
    /// Определяет, является ли треугольник прямоугольным, используя теорему Пифагора.
    /// </summary>
    /// <returns><c>true</c>, если треугольник прямоугольный; иначе <c>false</c>.</returns>
    public bool IsRightAngled()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);
        var a = sides[0];
        var b = sides[1];
        var c = sides[2];
        return Math.Abs(c * c - (a * a + b * b)) < 1e-10;
    }

    /// <summary>
    /// Проверяет, могут ли стороны с заданными длинами образовать допустимый треугольник.
    /// </summary>
    /// <param name="a">Длина стороны A.</param>
    /// <param name="b">Длина стороны B.</param>
    /// <param name="c">Длина стороны C.</param>
    /// <returns><c>true</c>, если стороны образуют допустимый треугольник; иначе <c>false</c>.</returns>
    private static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
