namespace MarsRover.Directions;

public class East : IDirection
{
    public Position MoveForward(Position position) => new(position.X + 1, position.Y);

    public string AsStringCommand() => "E";

    public IDirection ToRight() => new South();

    public IDirection ToLeft() => new North();
}