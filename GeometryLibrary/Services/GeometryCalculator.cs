using GeometryLibrary.Logic.Shapes;

namespace GeometryLibrary.Logic.Services;

/// <summary>
///     Calculates the area of geometric shapes using their respective area calculation strategies.
/// </summary>
public class GeometryCalculator : IGeometryCalculatorArea
{
    /// <summary>
    ///     Calculates the area of the specified geometric shape.
    /// </summary>
    /// <param name="shape">The geometric shape for which to calculate the area.</param>
    /// <returns>The calculated area of the shape.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the provided shape is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the shape type is not supported.</exception>
    public double CalculateArea(IShape shape)
    {
        if (shape == null)
            throw new ArgumentNullException(nameof(shape));

        var strategy = shape.GetAreaStrategy();

        return strategy?.CalculateArea() ??
               throw new InvalidOperationException($"Unsupported shape type: {shape.GetType().Name}");
    }
}