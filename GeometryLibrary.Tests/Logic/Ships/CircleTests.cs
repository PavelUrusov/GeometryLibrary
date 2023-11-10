using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Ships;
using GeometryLibrary.Logic.Strategies;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Ships;

public class CircleTests
{
    [Fact]
    public void GetAreaStrategy_ShouldReturnCircleAreaStrategy()
    {
        //Arrange
        var circle = new Circle(5.0);

        // Act
        var areaStrategy = circle.GetAreaStrategy();

        // Assert
        Assert.IsType<CircleAreaStrategy>(areaStrategy);
    }

    [Fact]
    public void CreateCircle_ShouldThrowShipException()
    {
        //Arrange
        var radius = -5.0;

        // Act & Assert
        Assert.Throws<ShipException>(() =>
        {
            var circle = new Circle(radius);
        });
    }
}