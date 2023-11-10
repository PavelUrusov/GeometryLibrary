using GeometryLibrary.Logic.Ships;

namespace GeometryLibrary.Logic.Services;

public class GeometryCalculator : IGeometryCalculatorArea
{
    public double CalculateArea(IShip ship)
    {
        if (ship == null) throw new ArgumentNullException(nameof(ship));

        var strategy = ship.GetAreaStrategy();

        return strategy?.CalculateArea() ??
               throw new InvalidOperationException($"Unsupported ship type: {ship.GetType().Name}");
    }
}