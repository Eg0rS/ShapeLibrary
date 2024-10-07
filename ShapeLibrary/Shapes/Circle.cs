using ShapeLibrary.Shapes.Abstractions;

namespace ShapeLibrary.Shapes;

/// <summary>
/// Представляет круг с определенным радиусом.
/// </summary>
/// <remarks>
/// Класс предоставляет методы для вычисления площади круга.
/// </remarks>
public class Circle : IShape
{
    /// <summary>
    /// Радиус круга.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Circle"/> с заданным радиусом.
    /// </summary>
    /// <param name="radius">Радиус круга (должен быть положительным).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если радиус неположительный.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным", nameof(radius));

        Radius = radius;
    }

    /// <summary>
    /// Создает копию существующего круга.
    /// </summary>
    /// <param name="circle">Экземпляр круга для копирования.</param>
    public Circle(Circle circle)
    {
        Radius = circle.Radius;
    }

    /// <summary>
    /// Вычисляет площадь круга.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    /// <summary>
    /// Вычисляет площадь треугольника с использованием формулы Герона.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
