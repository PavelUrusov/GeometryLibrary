using GeometryLibrary.Logic.Ships;

namespace GeometryLibrary.Logic.Services;

public interface IGeometryCalculatorArea
{
    double CalculateArea(IShip ship);
}