using GeometryLibrary.Logic.Services;
using GeometryLibrary.Logic.Shapes;

var ships = new List<IShape>
{
    new Circle(10),
    new Square(4),
    new Triangle(3, 4, 5)
};

var calc = new GeometryCalculator();

foreach (var ship in ships) Console.WriteLine($"Ship:{ship.ToString()}, Area: {calc.CalculateArea(ship)}");