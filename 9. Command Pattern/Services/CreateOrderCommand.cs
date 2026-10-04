public class CreateOrderCommand : ICommand
{
    private readonly OrderService _orderService;

    public CreateOrderCommand(OrderService orderService)
    {
        _orderService = orderService;
    }

    public void Execute()
    {
        _orderService.CreateOrder();
    }
}