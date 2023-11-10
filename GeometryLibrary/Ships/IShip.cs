using GeometryLibrary.Logic.Strategies;

namespace GeometryLibrary.Logic.Ships;

public interface IShip
{
    IAreaStrategy GetAreaStrategy();
    string? ToString();
}