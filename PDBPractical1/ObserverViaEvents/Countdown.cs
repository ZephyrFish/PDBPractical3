namespace PDBPractical1.ObserverViaEvents;

public class Countdown
{
    public event EventHandler<string>? handler;
    
    // Метод, который будет вызывать срабатывание события. 
    public void ItHappens(int delay)
    {
        Thread.Sleep(delay);
        Console.WriteLine("Countdown send a message!");
        handler?.Invoke(this, "nothing really happens...");
    }
    
}