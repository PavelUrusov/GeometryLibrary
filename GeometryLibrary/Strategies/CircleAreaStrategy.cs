namespace GeometryLibrary.Logic.Strategies;

public class CircleAreaStrategy : IAreaStrategy
{
    private readonly double _radius;

    public CircleAreaStrategy(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 4);
    }
}