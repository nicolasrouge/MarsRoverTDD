namespace MarsRover;

public class West
{
    public West()
    {
    }

    public Position MoveForward(Position position)
    {
        position._x--;
        return position;
    }
}