using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;
using GeometryLibrary.Logic.Utils;

namespace GeometryLibrary.Logic.Shapes;

/// <summary>
///     Represents a circle as a geometric shape.
/// </summary>
public class Circle : IShape
{
    /// <summary>
    ///     The radius of the circle.
    /// </summary>
    public readonly double Radius;

    /// <summary>
    ///     Initializes a new instance of the Circle class with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the circle. Should be >= 0.</param>
    /// <exception cref="ShapeException">Thrown if the radius is less than 0.</exception>
    public Circle(double radius)
    {
        if (GeometryUtils.IsPositiveNumber(radius) is false)
            throw new ShapeException("The radius must be >= 0", radius);

        Radius = radius;
    }

    /// <summary>
    ///     Gets the area calculation strategy for the circle.
    /// </summary>
    /// <returns>The area calculation strategy for the circle.</returns>
    public IAreaStrategy GetAreaStrategy()
    {
        return new CircleAreaStrategy(Radius);
    }
}