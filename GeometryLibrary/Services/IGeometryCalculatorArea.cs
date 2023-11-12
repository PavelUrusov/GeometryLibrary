using GeometryLibrary.Logic.Shapes;

namespace GeometryLibrary.Logic.Services;

/// <summary>
///     Represents a calculator for calculating the area of geometric shapes.
/// </summary>
public interface IGeometryCalculatorArea
{
    /// <summary>
    ///     Calculates the area of the specified geometric shape.
    /// </summary>
    /// <param name="shape">The geometric shape for which to calculate the area.</param>
    /// <returns>The calculated area of the shape.</returns>
    double CalculateArea(IShape shape);
}