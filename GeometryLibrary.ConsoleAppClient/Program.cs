using GeometryLibrary.Logic.Services;
using GeometryLibrary.Logic.Shapes;

var shapes = new List<IShape>
{
    new Circle(10),
    new Square(4),
    new Triangle(3, 4, 5)
};

var calc = new GeometryCalculator();

foreach (var shape in shapes) Console.WriteLine($"Ship:{shape.ToString()}, Area: {calc.CalculateArea(shape)}");