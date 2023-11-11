using GeometryLibrary.Logic.Shapes;

namespace GeometryLibrary.Logic.Services;

public class GeometryCalculator : IGeometryCalculatorArea
{
    public double CalculateArea(IShape shape)
    {
        if (shape == null) throw new ArgumentNullException(nameof(shape));

        var strategy = shape.GetAreaStrategy();

        return strategy?.CalculateArea() ??
               throw new InvalidOperationException($"Unsupported shape type: {shape.GetType().Name}");
    }
}