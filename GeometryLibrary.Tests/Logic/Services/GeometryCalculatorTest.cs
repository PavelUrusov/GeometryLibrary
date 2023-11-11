using GeometryLibrary.Logic.Services;
using GeometryLibrary.Logic.Shapes;
using GeometryLibrary.Logic.Strategies;
using Moq;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Services;

public class GeometryCalculatorTest
{
    [Fact]
    public void CalculateArea_UnknownShapesType_ThrowsException()
    {
        // Arrange
        IShape unknownShape = new UnknownShape();
        var calculator = new GeometryCalculator();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => calculator.CalculateArea(unknownShape));
    }

    [Fact]
    public void CalculateArea_NullShape_ThrowsException()
    {
        // Arrange
        IShape unknownShape = null!;
        var calculator = new GeometryCalculator();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(unknownShape));
    }


    [Fact]
    public void CalculateArea_ShouldWorkForDifferentShapesTypes()
    {
        // Arrange
        var circleMock = new Mock<IShape>();
        circleMock.Setup(c => c.GetAreaStrategy()).Returns(new CircleAreaStrategy(5.0));
        var triangleMock = new Mock<IShape>();
        triangleMock.Setup(t => t.GetAreaStrategy()).Returns(new TriangleAreaStrategy(3.0, 4.0, 5.0));
        var squareMock = new Mock<IShape>();
        squareMock.Setup(s => s.GetAreaStrategy()).Returns(new SquareAreaStrategy(4.0));
        var calculator = new GeometryCalculator();

        // Act
        var circleArea = calculator.CalculateArea(circleMock.Object);
        var triangleArea = calculator.CalculateArea(triangleMock.Object);
        var squareArea = calculator.CalculateArea(squareMock.Object);

        // Assert
        Assert.Equal(78.5398, circleArea);
        Assert.Equal(6.0000, triangleArea);
        Assert.Equal(16.0000, squareArea);
    }

    private class UnknownShape : IShape
    {
        public IAreaStrategy GetAreaStrategy()
        {
            return null;
        }
    }
}