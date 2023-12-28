using MarsRover.Directions;

namespace MarsRover;

public class MarsRover()
{
    private readonly string _initialState;
    private IDirection _direction;
    private Position _position;

    public MarsRover(string initialState) : this() => _initialState = initialState;

    public string? Execute(string commands)
    {
        var states = _initialState?.Split(":");
        var x = int.Parse((states[0]));
        var y = int.Parse(states[1]);
        var initialDirectionState = states[2];
        _position = new Position(x, y);
        _direction = DirectionFactory.CreateDirectionFrom(initialDirectionState);

        foreach (var command in commands)
        {
            switch (command)
            {
                case 'M':
                    _position = _direction.MoveForward(_position);
                    break;

                case 'R':
                    _direction = _direction.ToRight();
                    break;

                case 'L':
                    _direction = _direction.ToLeft();
                    break;
            }
        }

        return $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";
    }
}