using GeometryLibrary.Logic.Strategies;

namespace GeometryLibrary.Logic.Shapes;

/// <summary>
///     Represents a geometric shape.
/// </summary>
public interface IShape
{
    /// <summary>
    ///     Gets the strategy for calculating the area of the shape.
    /// </summary>
    /// <returns>The area calculation strategy for the shape.</returns>
    IAreaStrategy GetAreaStrategy();

    string? ToString();
}