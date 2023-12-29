using MarsRover.Commands;

namespace MarsRover;

public class MarsRover()
{
    private readonly string _initialState;
    private Rover _rover;
    private ICommand _command;

    public MarsRover(string initialState) : this() => _initialState = initialState;

    public string? Execute(string commands)
    {
        _rover = RoverFactory.CreateRover(_initialState);

        foreach (var command in commands)
        {
            _command = CommandFactory.CreateCommandFrom(command);
            _rover = _rover.Apply(_command);
        }

        return _rover.Print(_rover);
    }
}