namespace MarsRover.Directions;

public interface IDirection
{
    public Position MoveForward(Position position);

    public string TurnRight();
}