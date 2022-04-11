namespace PDBPractical1.ObserverViaEvents;

public class Countdown
{
    public event EventHandler<string>? handler;

    public void ItHappens(int delay)
    {
        Thread.Sleep(delay);
        Console.WriteLine("Countdown send a message!");
        handler?.Invoke(this, "nothing really happens...");
    }
    
}