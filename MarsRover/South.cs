namespace MarsRover;

public class South : IDirection
{
    public South()
    {
    }

    public Position MoveForward(Position position)
    {
        position._y--;
        return position;
    }
}