using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Strategies;

namespace GeometryLibrary.Logic.Shapes;

public class Triangle : IShape
{
    public readonly double SideA;
    public readonly double SideB;
    public readonly double SideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (IsTriangle(sideA, sideB, sideC) is false) throw new ShapeException("There is no triangle with such sides");
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public IAreaStrategy GetAreaStrategy()
    {
        return new TriangleAreaStrategy(SideA, SideB, SideC);
    }

    public static bool IsRightTriangle(double a, double b, double c)
    {
        return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
    }

    public static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}