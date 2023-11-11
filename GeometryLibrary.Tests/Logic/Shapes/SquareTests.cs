using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Shapes;
using GeometryLibrary.Logic.Strategies;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Shapes;

public class SquareTests
{
    [Fact]
    public void GetAreaStrategy_ShouldReturnSquareAreaStrategy()
    {
        //Arrange
        var square = new Square(5.0);

        // Act
        var areaStrategy = square.GetAreaStrategy();

        // Assert
        Assert.IsType<SquareAreaStrategy>(areaStrategy);
    }

    [Fact]
    public void CreateSquare_ShouldThrowShipException()
    {
        //Arrange
        var side = -5.0;

        // Act & Assert
        Assert.Throws<ShapeException>(() =>
        {
            var square = new Square(side);
        });
    }
}