using ShapeLibrary.Shapes;
using ShapeLibrary.Shapes.Abstractions;

namespace ShapeLibrary.Test;

public class CircleTests
{
    [Fact]
    public void Circle_Area_CorrectlyCalculated()
    {
        var circle = new Circle(5);
        var expectedArea = Math.PI * 25;
        
        var area = circle.GetArea();
        
        Assert.Equal(expectedArea, area, 5);
    }

    [Fact]
    public void Circle_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-5));
    }

    [Fact]
    public void Circle_ZeroRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Fact]
    public void Circle_Area_InterfaceImplementation_CorrectlyCalculated()
    {
        IShape circle = new Circle(3);
        var expectedArea = Math.PI * 9;
        
        var area = circle.GetArea();
        
        Assert.Equal(expectedArea, area, 5);
    }
}
