namespace MarsRover;

public class DirectionFactory
{
    public static IDirection CreateDirectionFrom(string direction)
    {
        return direction switch
        {
            "N" => new North(),
            "S" => new South(),
            "E" => new East(),
            "W" => new West(),
            _ => throw new NotSupportedException($"Direction {direction} is not supported.")
        };
    }
}