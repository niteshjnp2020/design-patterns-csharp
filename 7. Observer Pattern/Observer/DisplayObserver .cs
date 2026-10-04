public class DisplayObserver : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Display received notification: {message}");
    }
}