// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var handlers = new Dictionary<Type, object>
{
    {
        typeof(CreateOrderRequest),
        new CreateOrderHandler()
    }
};
var mediator = new Mediator(handlers);
mediator.Send(
    new CreateOrderRequest
    {
        CustomerId = 10,
        Amount = 500
    });

    