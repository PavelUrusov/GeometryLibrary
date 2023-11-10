using GeometryLibrary.Logic.Strategies;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Strategies;

public class TriangleStrategyTests
{
    [Fact]
    public void CalculateArea_IsShouldReturnCorrectResult()
    {
        //Arrange
        var triangleAreaStrategy = new TriangleAreaStrategy(3.0, 4.0, 5.0);
        var trueArea = 6.0000;

        //Act
        var result = triangleAreaStrategy.CalculateArea();

        //Assert
        Assert.Equal(trueArea, result);
    }
}