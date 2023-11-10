using GeometryLibrary.Logic.Utils;
using Xunit;

namespace GeometryLibrary.Tests.Logic.Utils;

public class GeometryUtilsTests
{
    [Fact]
    public void IsPositive_PositiveNumber_ShouldReturnTrue()
    {
        //Arrange
        var number = 5.0;

        //Act
        var result = GeometryUtils.IsPositive(number);

        //Assert
        Assert.True(result);
    }
}