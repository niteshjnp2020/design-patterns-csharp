public class CreateOrderHandler : IRequestHandler<CreateOrderRequest>
{
    public void Handle(CreateOrderRequest request)
    {
        // Logic to create an order based on the request data
        Console.WriteLine($"Creating order for CustomerId: {request.CustomerId} with Amount: {request.Amount}");
    }
}