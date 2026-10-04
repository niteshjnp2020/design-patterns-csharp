// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var orderService = new OrderService();
ICommand createOrderCommand = new CreateOrderCommand(orderService);
ICommand cancelOrderCommand = new CancelOrderCommand(orderService);

createOrderCommand.Execute();
cancelOrderCommand.Execute();
