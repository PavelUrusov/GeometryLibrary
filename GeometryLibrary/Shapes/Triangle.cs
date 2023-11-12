using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;

namespace GeometryLibrary.Logic.Shapes;

/// <summary>
///     Represents a triangle as a geometric shape.
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    ///     The length of side A of the triangle.
    /// </summary>
    public readonly double SideA;

    /// <summary>
    ///     The length of side B of the triangle.
    /// </summary>
    public readonly double SideB;

    /// <summary>
    ///     The length of side C of the triangle.
    /// </summary>
    public readonly double SideC;

    /// <summary>
    ///     Initializes a new instance of the Triangle class with the specified side lengths.
    /// </summary>
    /// <param name="sideA">Length of side A of the triangle.</param>
    /// <param name="sideB">Length of side B of the triangle.</param>
    /// <param name="sideC">Length of side C of the triangle.</param>
    /// <exception cref="ShapeException">Thrown if the sides do not form a valid triangle.</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (IsTriangle(sideA, sideB, sideC) is false)
            throw new ShapeException("There is no triangle with such sides");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    ///     Gets the area calculation strategy for the triangle.
    /// </summary>
    /// <returns>The area calculation strategy for the triangle.</returns>
    public IAreaStrategy GetAreaStrategy()
    {
        return new TriangleAreaStrategy(SideA, SideB, SideC);
    }

    /// <summary>
    ///     Determines if the triangle is a right-angled triangle.
    /// </summary>
    /// <param name="a">Length of side A.</param>
    /// <param name="b">Length of side B.</param>
    /// <param name="c">Length of side C.</param>
    /// <returns>True if the triangle is right-angled, false otherwise.</returns>
    public static bool IsRightTriangle(double a, double b, double c)
    {
        return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
    }

    /// <summary>
    ///     Determines if the side lengths form a valid triangle.
    /// </summary>
    /// <param name="a">Length of side A.</param>
    /// <param name="b">Length of side B.</param>
    /// <param name="c">Length of side C.</param>
    /// <returns>True if the side lengths form a valid triangle, false otherwise.</returns>
    public static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}