using ShapeLibrary.Shapes.Abstractions;

namespace ShapeLibrary.Shapes;

public class Triangle : IShape, ITriangle
{
    public double SideA { get; }

    public double SideB { get; }

    public double SideC { get; }

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

    public Triangle(Triangle triangle)
    {
        SideA = triangle.SideA;
        SideB = triangle.SideB;
        SideC = triangle.SideC;
    }

    public double GetArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngled()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);
        var a = sides[0];
        var b = sides[1];
        var c = sides[2];
        return Math.Abs(c * c - (a * a + b * b)) < 1e-10;
    }

    private static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
