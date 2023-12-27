namespace MarsRover;

public class West : IDirection
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