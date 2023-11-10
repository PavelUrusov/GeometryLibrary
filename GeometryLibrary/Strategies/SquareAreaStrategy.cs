namespace GeometryLibrary.Logic.Strategies;

public class SquareAreaStrategy : IAreaStrategy
{
    private readonly double _side;

    public SquareAreaStrategy(double side)
    {
        _side = side;
    }

    public double CalculateArea()
    {
        return Math.Round(Math.Pow(_side, 2), 4);
    }
}