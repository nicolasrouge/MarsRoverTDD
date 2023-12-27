namespace MarsRover;

public class MarsRover(string initialState)
{
    public string Execute(string commands)
    {
        var states = initialState.Split(":");

        var x = int.Parse((states[0]));
        var y = int.Parse(states[1]);
        var direction = states[2];

        if (commands != "M") return initialState;
        
        switch (direction)
        {
            case "N":
                y++;
                break;
            case "S":
                y--;
                break;
            case "E":
                x++;
                break;
            case "W":
                x--;
                break;
        }
        return $"{x}:{y}:{direction}";
    }
}