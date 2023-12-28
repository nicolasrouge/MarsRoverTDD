using MarsRover.Directions;

namespace MarsRover;

public class MarsRover()
{
    private readonly string _initialState;
    private Rover _rover;

    public MarsRover(string initialState) : this() => _initialState = initialState;

    public string? Execute(string commands)
    {
        var states = _initialState?.Split(":");
        var x = int.Parse((states[0]));
        var y = int.Parse(states[1]);
        var initialDirectionState = states[2];

        var position = new Position(x, y);
        var direction = DirectionFactory.CreateDirectionFrom(initialDirectionState);

        _rover = new Rover(direction, position);

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