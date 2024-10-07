namespace ShapeLibrary.Shapes.Abstractions;

/// <summary>
/// Интерфейс, представляющий геометрическую фигуру.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    double GetArea();
}
