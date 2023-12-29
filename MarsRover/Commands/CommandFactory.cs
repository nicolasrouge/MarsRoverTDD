namespace MarsRover.Commands
{
    public static class CommandFactory
    {
        public static ICommand CreateCommandFrom(char command) =>
            command switch
            {
                'M' => new MoveForwardCommand(),
                'R' => new TurnRightCommand(),
                'L' => new TurnLeftCommand(),
                _ => throw new ArgumentOutOfRangeException(nameof(command), command, null)
            };
    }
}