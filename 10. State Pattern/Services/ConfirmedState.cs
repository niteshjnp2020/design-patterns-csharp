public class ConfirmedState : IOrderState
{
    public void Confirm(Order order)
    {
        Console.WriteLine("Order is already confirmed.");
    }

    public void Ship(Order order)
    {
        // Transition to ShippedState
        order.SetState(new ShippedState());
        Console.WriteLine("Order shipped.");
    }

    public void Cancel(Order order)
    {
        // Transition to CanceledState
        order.SetState(new CanceledState());
        Console.WriteLine("Order canceled.");
    }
}