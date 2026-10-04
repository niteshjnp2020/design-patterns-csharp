public class PendingState : IOrderState
{
    public void Confirm(Order order)
    {
        // Transition to ConfirmedState
        order.SetState(new ConfirmedState());
        Console.WriteLine("Order confirmed.");
    }

    public void Ship(Order order)
    {
        Console.WriteLine("Cannot ship the order. It is still pending.");
    }

    public void Cancel(Order order)
    {
        // Transition to CanceledState
        Console.WriteLine("Order canceled.");
    }
}