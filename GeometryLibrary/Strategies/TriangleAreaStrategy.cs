namespace GeometryLibrary.Logic.Strategies;

public class TriangleAreaStrategy : IAreaStrategy
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public TriangleAreaStrategy(double sideA, double sideB, double sideC)
    {
        _sideB = sideB;
        _sideA = sideA;
        _sideC = sideC;
    }

    public double CalculateArea()
    {
        var pp = CalculatePerimeter() / 2;
        var area = Math.Sqrt(pp * (pp - _sideA) * (pp - _sideB) * (pp - _sideC));

        return Math.Round(area, 4);
    }

    private double CalculatePerimeter()
    {
        return _sideA + _sideB + _sideC;
    }
}