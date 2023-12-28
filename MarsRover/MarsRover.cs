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
            switch (command)
            {
                case 'M':
                    _rover = _rover.MoveForward();
                    break;

                case 'R':
                    _rover = _rover.TurnRight();
                    break;

                case 'L':
                    _rover = _rover.TurnLeft();
                    break;
            }
        }

        return $"{_rover.Position.X}:{_rover.Position.Y}:{_rover.Direction.AsStringCommand()}";
    }
}