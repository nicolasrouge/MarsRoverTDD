namespace MarsRover;

public class MarsRover()
{
    private readonly string _initialState;
    private Position _position;
    private readonly West _west;
    private readonly East _east;
    private readonly South _south;
    private readonly North _north;

    public MarsRover(string initialState) : this()
    {
        _initialState = initialState;
        _position = new Position();
        _west = new West();
        _east = new East();
        _south = new South();
        _north = new North();
    }

    public string Execute(string commands)
    {
        var states = _initialState.Split(":");

        _position._x = int.Parse((states[0]));
        _position._y = int.Parse(states[1]);
        var direction = states[2];

        if (commands != "M") return _initialState;

        switch (direction)
        {
            case "N":
                _position = _north.MoveForward(_position);
                break;

            case "S":
                _position = _south.MoveForward(_position);
                break;

            case "E":
                _position = _east.MoveForward(_position);
                break;

            case "W":
                _position = _west.MoveForward(_position);
                break;
        }
        return $"{_position._x}:{_position._y}:{direction}";
    }
}