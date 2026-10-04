public class ShippedState : IOrderState
{
    public void Confirm(Order order)
    {
        Console.WriteLine("Order is already shipped and cannot be confirmed.");
    }

    public void Ship(Order order)
    {
        Console.WriteLine("Order is already shipped.");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine("Cannot cancel the order. It has already been shipped.");
    }
}