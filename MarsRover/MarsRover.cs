namespace MarsRover;

public class MarsRover()
{
    private readonly string _initialState;
    private Position _position;
    private IDirection _direction;

    public MarsRover(string initialState) : this()
    {
        _initialState = initialState;
        _position = new Position();
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
                _direction = new North();
                break;

            case "S":
                _direction = new South();
                break;

            case "E":
                _direction = new East();
                break;

            case "W":
                _direction = new West();
                break;
        }
        _position = _direction.MoveForward(_position);

        return $"{_position._x}:{_position._y}:{direction}";
    }
}