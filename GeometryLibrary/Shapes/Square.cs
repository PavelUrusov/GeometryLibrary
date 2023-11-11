using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;
using GeometryLibrary.Logic.Utils;

namespace GeometryLibrary.Logic.Shapes;

public class Square : IShape
{
    public readonly double Side;

    public Square(double side)
    {
        if (GeometryUtils.IsPositiveNumber(side) is false) throw new ShapeException("The side must be >= 0", side);
        Side = side;
    }

    public IAreaStrategy GetAreaStrategy()
    {
        return new SquareAreaStrategy(Side);
    }
}