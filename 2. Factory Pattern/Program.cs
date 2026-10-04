// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var factory = new NotificationFactory();
INotification emailNotification = factory.create("email");
emailNotification.Send("This is an email notification.");
INotification smsNotification = factory.create("sms");
smsNotification.Send("This is an SMS notification.");

