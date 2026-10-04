public class EmailNotificationServices : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Email Notification: {message} /n/n");
    }
}