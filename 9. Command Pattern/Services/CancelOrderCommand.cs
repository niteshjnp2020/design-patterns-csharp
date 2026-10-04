public class CancelOrderCommand  : ICommand
{
    private readonly OrderService _orderService;

    public CancelOrderCommand(OrderService orderService)
    {
        _orderService = orderService;
    }

    public void Execute()
    {
        //The receiver contains the actual business logic.
        _orderService.CancelOrder();
    }
}