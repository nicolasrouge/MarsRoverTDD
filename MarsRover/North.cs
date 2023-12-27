namespace MarsRover;

public class North : IDirection
{
    public North()
    {
    }

    public Position MoveForward(Position position)
    {
        position._y++;
        return position;
    }
}