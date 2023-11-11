using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;
using GeometryLibrary.Logic.Utils;

namespace GeometryLibrary.Logic.Shapes;

public class Circle : IShape
{
    public readonly double Radius;

    public Circle(double radius)
    {
        if (GeometryUtils.IsPositiveNumber(radius) is false) throw new ShapeException("The radius must be >= 0", radius);

        Radius = radius;
    }

    public IAreaStrategy GetAreaStrategy()
    {
        return new CircleAreaStrategy(Radius);
    }
}