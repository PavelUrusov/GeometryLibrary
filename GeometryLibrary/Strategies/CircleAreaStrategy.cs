namespace GeometryLibrary.Logic.Strategies;

/// <summary>
///     Represents a strategy for calculating the area of a circle.
/// </summary>
public class CircleAreaStrategy : IAreaStrategy
{
    /// <summary>
    ///     The radius of the circle for which the area is calculated.
    /// </summary>
    private readonly double _radius;

    /// <summary>
    ///     Initializes a new instance of the CircleAreaStrategy class with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    public CircleAreaStrategy(double radius)
    {
        _radius = radius;
    }

    /// <summary>
    ///     Calculates the area of the circle based on its radius.
    /// </summary>
    /// <returns>The calculated area of the circle.</returns>
    public double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 4);
    }
}