public class LoggingNotificationDecorator : INotificationService
{
    private readonly INotificationService _notificationService;

    public LoggingNotificationDecorator(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Logging: Sending notification with message: {message}");
        _notificationService.Send(message);
    }
}