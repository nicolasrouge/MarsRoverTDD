using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverShould
{

    /// <summary>
    /// Test to ensure that we can initialize the rover with different states.
    /// </summary>
    /// <param name="initialState"></param>
    [Theory]
    [InlineData("0:0:N")]
    [InlineData("1:1:S")]
    public void PrintInitialState(string initialState)
    {
        //Arrange
        var marsRover = new MarsRover(initialState);

        //Act
        var result = marsRover.Execute("");

        //Assert
        result.Should().Be(initialState);
    }

    /// <summary>
    /// Move the Rover forward in every direction.
    /// </summary>
    /// <param name="initialState"></param>
    /// <param name="expectedResult"></param>
    [Theory]
    [InlineData("0:0:N", "0:1:N")]
    [InlineData("1:1:N", "1:2:N")]
    [InlineData("1:1:W", "0:1:W")]
    [InlineData("1:1:E", "2:1:E")]
    [InlineData("1:1:S", "1:0:S")]
    public void MoveForward(string initialState, string expectedResult)
    {
        //Arrange
        var marsRover = new MarsRover(initialState);

        //Act
        var result = marsRover.Execute("M");

        //Assert
        result.Should().Be(expectedResult);
    }
}