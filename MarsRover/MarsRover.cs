namespace MarsRover;

public class MarsRover()
{
    private readonly string? _initialState;
    private Position _position;
    private IDirection _direction;

    public MarsRover(string initialState) : this()
    {
        _initialState = initialState;
        _position = new Position();
    }

    public string? Execute(string commands)
    {
        var states = _initialState?.Split(":");

        _position._x = int.Parse((states[0]));
        _position._y = int.Parse(states[1]);
        var direction = states[2];

        if (commands != "M") return _initialState;

        _direction = DirectionFactory.CreateDirectionFrom(direction);
        _position = _direction.MoveForward(_position);

        return $"{_position._x}:{_position._y}:{direction}";
    }
}