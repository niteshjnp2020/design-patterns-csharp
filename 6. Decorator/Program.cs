// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

INotificationService emailNotificationService = new EmailNotificationServices();
emailNotificationService = new LoggingNotificationDecorator(emailNotificationService);
emailNotificationService.Send("This is a test notification.");

Console.WriteLine("\nNow with retry decorator:");
INotificationService retryNotificationService = new RetryNotificationDecorator(emailNotificationService);
retryNotificationService.Send("This is a test notification with retry.");
