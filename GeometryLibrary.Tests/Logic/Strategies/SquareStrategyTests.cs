using GeometryLibrary.Logic.Strategies;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Strategies;

public class SquareStrategyTests
{
    [Fact]
    public void CalculateArea_IsShouldReturnCorrectResult()
    {
        //Arrange
        var sqAreaStrategy = new SquareAreaStrategy(4.0);
        var trueArea = 16.0000;

        //Act
        var result = sqAreaStrategy.CalculateArea();

        //Assert
        Assert.Equal(trueArea, result);
    }
}