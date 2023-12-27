namespace MarsRover;

public class North
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