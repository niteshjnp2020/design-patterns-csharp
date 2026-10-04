// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var Token = new TokenService();
var customerObserver = new CustomerObserver();
var displayObserver = new DisplayObserver();
Token.Subscribe(customerObserver);
Token.Subscribe(displayObserver);

Token.Notify("New token generated: 12345");
