using GeometryLibrary.Logic.Strategies;

namespace GeometryLibrary.Logic.Shapes;

public interface IShape
{
    IAreaStrategy GetAreaStrategy();
    string? ToString();
}