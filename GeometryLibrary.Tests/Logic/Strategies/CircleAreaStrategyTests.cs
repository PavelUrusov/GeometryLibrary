using GeometryLibrary.Logic.Strategies;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Strategies;

public class CircleAreaStrategyTests
{
    [Fact]
    public void CalculateArea_IsShouldReturnCorrectResult()
    {
        //Arrange
        var circleAreaStrategy = new CircleAreaStrategy(5.0);
        var trueArea = 78.5398;

        //Act
        var result = circleAreaStrategy.CalculateArea();

        //Assert
        Assert.Equal(trueArea, result);
    }
}