namespace MarsRover.Directions;

public class West : IDirection
{
    public Position MoveForward(Position position) => new(position.X - 1, position.Y);
}