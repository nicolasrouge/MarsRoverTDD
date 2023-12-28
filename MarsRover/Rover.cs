using MarsRover.Directions;

namespace MarsRover
{
    public class Rover
    {
        public IDirection Direction { get; set; }
        public Position Position;

        public Rover(IDirection direction, Position position)
        {
            Direction = direction;
            Position = position;
        }

        public Rover()
        {
        }

        public void TurnLeft() => this.Direction = this.Direction.ToLeft();

        public void TurnRight() => this.Direction = this.Direction.ToRight();

        public void MoveForward() => this.Position = this.Direction.MoveForward(this.Position);
    }
}