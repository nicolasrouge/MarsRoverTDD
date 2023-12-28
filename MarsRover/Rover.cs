using MarsRover.Directions;

namespace MarsRover
{
    public class Rover(IDirection direction, Position position)
    {
        public readonly IDirection Direction = direction;
        public readonly Position Position = position;

        public Rover TurnLeft() => new(Direction.ToLeft(), Position);

        public Rover TurnRight() => new(Direction.ToRight(), Position);

        public Rover MoveForward() => new(Direction, Direction.MoveForward(Position));
    }
}