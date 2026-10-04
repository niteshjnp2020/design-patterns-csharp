public class EmailNotificationServices : INotification
{
    public void Send(string body)
    {
        // Logic to send email notification
        Console.WriteLine($"Sending Email Notification: {body}");
    }
}