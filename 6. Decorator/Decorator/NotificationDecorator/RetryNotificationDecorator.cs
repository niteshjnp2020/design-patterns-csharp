public class RetryNotificationDecorator : INotificationService
{
    private readonly INotificationService _notificationService;

    public RetryNotificationDecorator(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void Send(string message)
    {
        int retryCount = 3;
        for (int i = 0; i < retryCount; i++)
        {
            try
            {
                Console.WriteLine("[RETRY] Starting");
                _notificationService.Send(message);
                break; // Exit loop if successful
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Attempt {i + 1} failed: {ex.Message}");
                if (i == retryCount - 1)
                {
                    Console.WriteLine("All retry attempts failed.");
                }
            }
        }
    }
}