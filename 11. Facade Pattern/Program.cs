// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var customerService = new CustomerService();
var queueService = new QueueService();
var tokenService = new TokenService();
var notificationService = new NotificationService();
var queueFacade = new QueueFacade(customerService, queueService, tokenService, notificationService);
var token =   queueFacade.GenerateToken(10, 5);