namespace GeometryLibrary.Logic.Strategies;

/// <summary>
///     Represents a strategy for calculating the area of a geometric shape.
/// </summary>
public interface IAreaStrategy
{
    /// <summary>
    ///     Calculates the area of the geometric shape.
    /// </summary>
    /// <returns>The calculated area of the shape.</returns>
    double CalculateArea();
}