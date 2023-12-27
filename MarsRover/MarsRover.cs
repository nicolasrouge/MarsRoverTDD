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
        var direction = states[2];

        var position = new Position(x, y);

        if (commands != "M") return _initialState;

        _direction = DirectionFactory.CreateDirectionFrom(direction);

        _position = _direction.MoveForward(position);

        return $"{_position.X}:{_position.Y}:{direction}";
    }
}