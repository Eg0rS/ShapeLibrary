namespace ShapeLibrary.Shapes.Abstractions;

/// <summary>
/// Интерфейс, представляющий треугольник.
/// </summary>
/// <remarks>
/// Содержит метод для определения, является ли треугольник прямоугольным.
/// </remarks>
public interface ITriangle
{
    /// <summary>
    /// Определяет, является ли треугольник прямоугольным.
    /// </summary>
    /// <returns><c>true</c>, если треугольник прямоугольный; иначе <c>false</c>.</returns>
    bool IsRightAngled();
}
