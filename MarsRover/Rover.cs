using MarsRover.Directions;

namespace MarsRover
{
    public class Rover
    {
        public readonly IDirection Direction;
        public readonly Position Position;

        public Rover(IDirection direction, Position position)
        {
            Direction = direction;
            Position = position;
        }

        public Rover()
        {
        }

        public Rover TurnLeft() => new(Direction.ToLeft(), Position);

        public Rover TurnRight() => new(Direction.ToRight(), Position);

        public Rover MoveForward() => new(Direction, Direction.MoveForward(Position));
    }
}