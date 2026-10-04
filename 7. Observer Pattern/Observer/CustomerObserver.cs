public class CustomerObserver : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Customer received notification: {message}");
    }
}