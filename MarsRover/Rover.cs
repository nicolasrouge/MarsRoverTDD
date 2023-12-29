using MarsRover.Commands;
using MarsRover.Directions;

namespace MarsRover
{
    public class Rover(IDirection direction, Position position)
    {
        public readonly IDirection Direction = direction;
        public readonly Position Position = position;

        public Rover Apply(ICommand command)
        {
            return ApplyCommand((dynamic)command);
        }

        private Rover ApplyCommand(MoveForwardCommand c) 
            => new(Direction, Direction.MoveForward(Position));

        private Rover ApplyCommand(TurnRightCommand c) 
            => new(Direction.ToRight(), Position);

        private Rover ApplyCommand(TurnLeftCommand c) 
            => new(Direction.ToLeft(), Position);

        public string Print(Rover rover)
        {
            return $"{rover.Position.X}:{rover.Position.Y}:{rover.Direction.AsStringCommand()}";
        }
    }
}