using GeometryLibrary.Logic.Exceptions;
using GeometryLibrary.Logic.Ships;
using GeometryLibrary.Logic.Strategies;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Ships;

public class TriangleTests
{
    [Fact]
    public void GetAreaStrategy_ShouldReturnSquareAreaStrategy()
    {
        //Arrange
        var triangle = new Triangle(8.0, 6.0, 10.0);

        // Act
        var areaStrategy = triangle.GetAreaStrategy();

        // Assert
        Assert.IsType<TriangleAreaStrategy>(areaStrategy);
    }

    [Fact]
    public void CreateTriangle_ShouldThrowShipException()
    {
        //Arrange
        double a = 8.0, b = 6.0, c = 1000.0;

        //Act & Assert
        Assert.Throws<ShipException>(() =>
        {
            var triangle = new Triangle(a, b, c);
        });
    }

    [Fact]
    public void IsTriangle_ShouldReturnTrue()
    {
        //Arrange
        double a = 8.0, b = 6.0, c = 10.0;

        //Act
        var result = Triangle.IsTriangle(a, b, c);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void IsTriangle_ShouldReturnFalse()
    {
        //Arrange
        double a = 8.0, b = 6.0, c = 1000.0;

        //Act
        var result = Triangle.IsTriangle(a, b, c);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnTrue()
    {
        //Arrange
        double a = 8.0, b = 6.0, c = 10.0;

        //Act
        var result = Triangle.IsRightTriangle(a, b, c);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnFalse()
    {
        //Arrange
        double a = 8.0, b = 6.0, c = 11.0;

        //Act
        var result = Triangle.IsRightTriangle(a, b, c);

        //Assert
        Assert.False(result);
    }
}