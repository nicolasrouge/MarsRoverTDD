namespace MarsRover;

public class South
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