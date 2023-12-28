namespace MarsRover.Directions;

public class South : IDirection
{
    public Position MoveForward(Position position) => new(position.X, position.Y - 1);

    public string AsStringCommand() => "S";

    public IDirection ToRight() => new West();

    public IDirection ToLeft() => new East();
}