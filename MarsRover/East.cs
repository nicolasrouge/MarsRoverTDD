namespace MarsRover;

public class East
{
    public East()
    {
    }

    public Position MoveForward(Position position)
    {
        position._x++;
        return position;
    }
}