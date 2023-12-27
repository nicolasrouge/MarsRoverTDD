namespace MarsRover;

public class East : IDirection
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