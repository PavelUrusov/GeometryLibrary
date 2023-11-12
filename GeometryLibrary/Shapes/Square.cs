using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;
using GeometryLibrary.Logic.Utils;

namespace GeometryLibrary.Logic.Shapes;

/// <summary>
///     Represents a square as a geometric shape.
/// </summary>
public class Square : IShape
{
    /// <summary>
    ///     The length of a side of the square.
    /// </summary>
    public readonly double Side;

    /// <summary>
    ///     Initializes a new instance of the Square class with the specified side length.
    /// </summary>
    /// <param name="side">The length of a side of the square. Should be >= 0.</param>
    /// <exception cref="ShapeException">Thrown if the side length is less than 0.</exception>
    public Square(double side)
    {
        if (GeometryUtils.IsPositiveNumber(side) is false)
            throw new ShapeException("The side must be >= 0", side);

        Side = side;
    }

    /// <summary>
    ///     Gets the area calculation strategy for the square.
    /// </summary>
    /// <returns>The area calculation strategy for the square.</returns>
    public IAreaStrategy GetAreaStrategy()
    {
        return new SquareAreaStrategy(Side);
    }
}