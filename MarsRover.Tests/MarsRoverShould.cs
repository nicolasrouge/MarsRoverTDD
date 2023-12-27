using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Theory]
    [InlineData("0:0:N")]
    [InlineData("1:1:S")]
    public void PrintInitialState(string initialState)
    {
        //Arrange
        var marsRover = new MarsRover(initialState);

        //Act
        var result = marsRover.Execute();

        //Assert
        result.Should().Be(initialState);
    }
}