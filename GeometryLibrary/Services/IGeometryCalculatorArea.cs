using GeometryLibrary.Logic.Shapes;

namespace GeometryLibrary.Logic.Services;

public interface IGeometryCalculatorArea
{
    double CalculateArea(IShape shape);
}