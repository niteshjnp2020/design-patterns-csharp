public class SMSNotificationServices : INotification
{
    public void Send(string message)
    {
        // Logic to send SMS notification
        Console.WriteLine($"Sending SMS Notification: {message}");
    }
}