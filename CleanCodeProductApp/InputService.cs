namespace CleanCodeOdev;

public class InputService : IInputService
{
    public string GetInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}