namespace GeometryLibrary.Logic.Strategies;

/// <summary>
///     Represents a strategy for calculating the area of a triangle.
/// </summary>
public class TriangleAreaStrategy : IAreaStrategy
{
    /// <summary>
    ///     The length of side A of the triangle.
    /// </summary>
    private readonly double _sideA;

    /// <summary>
    ///     The length of side B of the triangle.
    /// </summary>
    private readonly double _sideB;

    /// <summary>
    ///     The length of side C of the triangle.
    /// </summary>
    private readonly double _sideC;

    /// <summary>
    ///     Initializes a new instance of the TriangleAreaStrategy class with the specified side lengths.
    /// </summary>
    /// <param name="sideA">Length of side A of the triangle.</param>
    /// <param name="sideB">Length of side B of the triangle.</param>
    /// <param name="sideC">Length of side C of the triangle.</param>
    public TriangleAreaStrategy(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <summary>
    ///     Calculates the area of the triangle based on its side lengths.
    /// </summary>
    /// <returns>The calculated area of the triangle.</returns>
    public double CalculateArea()
    {
        var semiPerimeter = CalculatePerimeter() / 2;
        var area = Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) *
                             (semiPerimeter - _sideC));

        return Math.Round(area, 4);
    }

    /// <summary>
    ///     Calculates the perimeter of the triangle.
    /// </summary>
    /// <returns>The calculated perimeter of the triangle.</returns>
    private double CalculatePerimeter()
    {
        return _sideA + _sideB + _sideC;
    }
}