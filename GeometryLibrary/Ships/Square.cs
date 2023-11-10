using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;
using GeometryLibrary.Logic.Utils;

namespace GeometryLibrary.Logic.Ships;

public class Square : IShip
{
    public readonly double Side;

    public Square(double side)
    {
        if (!GeometryUtils.IsPositive(side)) throw new ShipException("The side must be >= 0", side);
        Side = side;
    }

    public IAreaStrategy GetAreaStrategy()
    {
        return new SquareAreaStrategy(Side);
    }
}