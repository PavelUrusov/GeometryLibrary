using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;
using GeometryLibrary.Logic.Utils;

namespace GeometryLibrary.Logic.Ships;

public class Circle : IShip
{
    public readonly double Radius;

    public Circle(double radius)
    {
        if (!GeometryUtils.IsPositive(radius)) throw new ShipException("The radius must be >= 0", radius);

        Radius = radius;
    }

    public IAreaStrategy GetAreaStrategy()
    {
        return new CircleAreaStrategy(Radius);
    }
}