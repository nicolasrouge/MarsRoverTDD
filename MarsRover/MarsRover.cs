namespace MarsRover;

public class Position
{
    public int _x;
    public int _y;
}

public class MarsRover(string initialState)
{
    private Position _position = new();

    public string Execute(string commands)
    {
        var states = initialState.Split(":");

        _position._x = int.Parse((states[0]));
        _position._y = int.Parse(states[1]);
        var direction = states[2];

        if (commands != "M") return initialState;
        
        switch (direction)
        {
            case "N":
                _position = MoveNorth(_position);
                break;
            case "S":
                _position = MoveSouth(_position);
                break;
            case "E":
                _position = MoveEst(_position);
                break;
            case "W":
                _position = MoveWest(_position);
                break;
        }
        return $"{_position._x}:{_position._y}:{direction}";
    }

    private Position MoveWest(Position position)
    {
        position._x--;
        return position;
    }

    private Position MoveEst(Position position)
    {
        position._x++;
        return position;
    }

    private Position MoveSouth(Position position)
    {
        position._y--;
        return position;
    }

    private Position MoveNorth(Position position)
    {
        position._y++;
        return position;
    }
}