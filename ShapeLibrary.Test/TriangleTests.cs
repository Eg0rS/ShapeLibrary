using ShapeLibrary.Shapes;
using ShapeLibrary.Shapes.Abstractions;

namespace ShapeLibrary.Test;

public class TriangleTests
{
    [Fact]
    public void Triangle_Area_CorrectlyCalculated()
    {
        var triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;

        var area = triangle.GetArea();

        Assert.Equal(expectedArea, area, 5);
    }

    [Fact]
    public void Triangle_IsRightAngled_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRightAngled = triangle.IsRightAngled();

        Assert.True(isRightAngled);
    }

    [Fact]
    public void Triangle_IsRightAngled_ReturnsFalse()
    {
        var triangle = new Triangle(3, 4, 6);

        var isRightAngled = triangle.IsRightAngled();

        Assert.False(isRightAngled);
    }

    [Fact]
    public void Triangle_InvalidSides_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Fact]
    public void Triangle_NegativeSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
    }

    [Fact]
    public void Triangle_ZeroSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
    }

    [Fact]
    public void Triangle_Area_InterfaceImplementation_CorrectlyCalculated()
    {
        IShape triangle = new Triangle(6, 8, 10);
        double expectedArea = 24;

        var area = triangle.GetArea();

        Assert.Equal(expectedArea, area, 5);
    }

    [Fact]
    public void Triangle_IsRightAngled_InterfaceImplementation_ReturnsTrue()
    {
        ITriangle triangle = new Triangle(5, 12, 13);

        var isRightAngled = triangle.IsRightAngled();

        Assert.True(isRightAngled);
    }

    [Fact]
    public void Triangle_IsRightAngled_InterfaceImplementation_ReturnsFalse()
    {
        ITriangle triangle = new Triangle(5, 5, 5);

        var isRightAngled = triangle.IsRightAngled();

        Assert.False(isRightAngled);
    }
}
