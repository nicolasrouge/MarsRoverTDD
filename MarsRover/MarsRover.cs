namespace MarsRover;

public class MarsRover
{
    public string InitialState { get; } = "";

    public MarsRover(string initialState)
    {
        InitialState = initialState;
    }

    public string Execute()
    {
        return InitialState;
    }
}