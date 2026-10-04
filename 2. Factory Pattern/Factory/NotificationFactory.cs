public class NotificationFactory
{
    public INotification create(string notificationType)
    {
        return notificationType.ToLower() switch
        {
            "email" =>new EmailNotificationServices(),
            "sms" => new SMSNotificationServices(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}