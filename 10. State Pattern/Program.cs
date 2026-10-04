// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var order = new Order();
order.Confirm(); // Transition to ConfirmedState
order.Ship(); // Transition to ShippedState
order.Cancel(); // Cannot cancel the order. It has already been shipped.