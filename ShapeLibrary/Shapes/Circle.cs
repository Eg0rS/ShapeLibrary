using ShapeLibrary.Shapes.Abstractions;

namespace ShapeLibrary.Shapes;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным", nameof(radius));

        Radius = radius;
    }

    public Circle(Circle circle)
    {
        Radius = circle.Radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
