namespace MarsRover.Directions;

public class North : IDirection
{
    public Position MoveForward(Position position) => new(position.X, position.Y + 1);

    public string AsStringCommand() => "N";

    public IDirection ToRight() => new East();

    public IDirection ToLeft() => new West();
}