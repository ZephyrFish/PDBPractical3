namespace PDBPractical1.ObserverViaEvents;

public class Subscriber
{
    private readonly string name;
    public Subscriber(Countdown cd, string name)
    {
        cd.handler += DisplayMessage;
        this.name = name;
    }

    private void DisplayMessage(object? sender, string e)
    {
        Console.WriteLine($"Subscriber {name} reacts to event. Publisher says: {e}");
    }
}