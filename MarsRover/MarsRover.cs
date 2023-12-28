using MarsRover.Directions;

namespace MarsRover;

public class MarsRover()
{
    private readonly string _initialState;
    private Rover _rover;

    public MarsRover(string initialState) : this() => _initialState = initialState;

    public string? Execute(string commands)
    {
        _rover = RoverFactory.CreateRover(_initialState);

        foreach (var command in commands)
        {
            _rover = command switch
            {
                'M' => _rover.MoveForward(),
                'R' => _rover.TurnRight(),
                'L' => _rover.TurnLeft(),
                _ => _rover
            };
        }

        return $"{_rover.Position.X}:{_rover.Position.Y}:{_rover.Direction.AsStringCommand()}";
    }
}