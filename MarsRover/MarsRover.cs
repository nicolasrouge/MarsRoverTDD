using MarsRover.Directions;

namespace MarsRover;

public class MarsRover()
{
    private readonly string _initialState;
    private readonly Rover _rover = new();

    public MarsRover(string initialState) : this() => _initialState = initialState;

    public string? Execute(string commands)
    {
        var states = _initialState?.Split(":");
        var x = int.Parse((states[0]));
        var y = int.Parse(states[1]);
        var initialDirectionState = states[2];
        _rover.Position = new Position(x, y);
        _rover.Direction = DirectionFactory.CreateDirectionFrom(initialDirectionState);

        foreach (var command in commands)
        {
            switch (command)
            {
                case 'M':
                    _rover.MoveForward();
                    break;

                case 'R':
                    _rover.TurnRight();
                    break;

                case 'L':
                    _rover.TurnLeft();
                    break;
            }
        }

        return $"{_rover.Position.X}:{_rover.Position.Y}:{_rover.Direction.AsStringCommand()}";
    }
}