using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    /// <summary>
    /// Test to ensure the correct execution of the commands.
    /// </summary>
    /// <param name="initialState"></param>
    /// <param name="expectedResult"></param>
    [Theory]
    [InlineData("0:0:N", "", "0:0:N")]
    [InlineData("1:1:S", "", "1:1:S")]
    [InlineData("0:0:N", "M", "0:1:N")]
    [InlineData("1:1:N", "M", "1:2:N")]
    [InlineData("1:1:W", "M", "0:1:W")]
    [InlineData("1:1:E", "M", "2:1:E")]
    [InlineData("1:1:S", "M", "1:0:S")]
    [InlineData("1:1:N", "R", "1:1:E")]
    [InlineData("1:1:S", "R", "1:1:W")]
    [InlineData("1:1:E", "R", "1:1:S")]
    [InlineData("1:1:W", "R", "1:1:N")]
    public void ExecuteCommands(string initialState, string commands, string expectedResult)
    {
        //Arrange
        var marsRover = new MarsRover(initialState);

        //Act
        var result = marsRover.Execute(commands);

        //Assert
        result.Should().Be(expectedResult);
    }
}