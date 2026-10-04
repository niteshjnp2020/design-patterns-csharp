public class CreateOrderRequest : IRequest
{
    public int CustomerId { get; set; }

    public decimal Amount { get; set; }
}