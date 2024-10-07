### Ответ на 2 вопрос
```sql
SELECT
    P.ProductName,
    C.CategoryName
FROM
    Products AS P
LEFT JOIN
    ProductCategories AS PC ON P.ProductID = PC.ProductID
LEFT JOIN
    Categories AS C ON PC.CategoryID = C.CategoryID;
```

# Shape Library 

Библиотека предоставляет интерфейсы и классы для работы с фигурами, такими как круг и треугольник.

## Интерфейсы и Классы

### IShape
- **`GetArea()`**: Возвращает площадь фигуры.

### ITriangle
- **`IsRightAngled()`**: Проверяет, является ли треугольник прямоугольным.

### Circle
- **`Radius`**: Радиус круга.
- **`Circle(double radius)`**: Создает круг, выбрасывает `ArgumentException` при неположительном радиусе.
- **`GetArea()`**: Площадь круга (π * Radius²).

### Triangle
- **`SideA, SideB, SideC`**: Длины сторон треугольника.
- **`Triangle(double sideA, double sideB, double sideC)`**: Создает треугольник, выбрасывает `ArgumentException`, если стороны не образуют треугольник.
- **`GetArea()`**: Площадь по формуле Герона.
- **`IsRightAngled()`**: Проверка по теореме Пифагора.

## Примеры

### Circle
```csharp
var circle = new Circle(5);
Console.WriteLine($"Площадь круга: {circle.GetArea()}");
```

### Triangle
```csharp
var triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
Console.WriteLine($"Треугольник прямоугольный: {triangle.IsRightAngled()}");
```

