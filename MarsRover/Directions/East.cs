namespace MarsRover.Directions;

public class East : IDirection
{
    public Position MoveForward(Position position) => new(position.X + 1, position.Y);

    public string TurnRight() => "S";
}