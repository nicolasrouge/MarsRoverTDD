using MarsRover.Directions;

namespace MarsRover;

public static class RoverFactory
{
    public static Rover CreateRover(string initialState)
    {
        var states = initialState.Split(":");
        var x = int.Parse(states[0]);
        var y = int.Parse(states[1]);
        var initialDirectionState = states[2];
        var newPosition = new Position(x, y);
        var newDirection = DirectionFactory.CreateDirectionFrom(initialDirectionState);
        return new Rover(newDirection, newPosition);
    }
}