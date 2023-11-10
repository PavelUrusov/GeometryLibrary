using GeometryLibrary.Logic.Services;
using GeometryLibrary.Logic.Ships;
using GeometryLibrary.Logic.Strategies;
using Moq;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Services;

public class GeometryCalculatorTest
{
    [Fact]
    public void CalculateArea_UnknownShipType_ThrowsException()
    {
        // Arrange
        IShip unknownShip = new UnknownShip();
        var calculator = new GeometryCalculator();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => calculator.CalculateArea(unknownShip));
    }

    [Fact]
    public void CalculateArea_NullShip_ThrowsException()
    {
        // Arrange
        IShip unknownShip = null!;
        var calculator = new GeometryCalculator();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(unknownShip));
    }


    [Fact]
    public void CalculateArea_ShouldWorkForDifferentShipTypes()
    {
        // Arrange
        var circleMock = new Mock<IShip>();
        circleMock.Setup(c => c.GetAreaStrategy()).Returns(new CircleAreaStrategy(5.0));
        var triangleMock = new Mock<IShip>();
        triangleMock.Setup(t => t.GetAreaStrategy()).Returns(new TriangleAreaStrategy(3.0, 4.0, 5.0));
        var squareMock = new Mock<IShip>();
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

    private class UnknownShip : IShip
    {
        public IAreaStrategy GetAreaStrategy()
        {
            return null;
        }
    }
}