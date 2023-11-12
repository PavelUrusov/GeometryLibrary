namespace GeometryLibrary.Logic.Strategies;

/// <summary>
///     Represents a strategy for calculating the area of a square.
/// </summary>
public class SquareAreaStrategy : IAreaStrategy
{
    /// <summary>
    ///     The length of a side of the square for which the area is calculated.
    /// </summary>
    private readonly double _side;

    /// <summary>
    ///     Initializes a new instance of the SquareAreaStrategy class with the specified side length.
    /// </summary>
    /// <param name="side">The length of a side of the square.</param>
    public SquareAreaStrategy(double side)
    {
        _side = side;
    }

    /// <summary>
    ///     Calculates the area of the square based on the length of its side.
    /// </summary>
    /// <returns>The calculated area of the square.</returns>
    public double CalculateArea()
    {
        return Math.Round(Math.Pow(_side, 2), 4);
    }
}