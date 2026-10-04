public class CanceledState : IOrderState
{
    public void Confirm(Order order)
    {
        Console.WriteLine("Cannot confirm the order. It has been canceled.");
    }

    public void Ship(Order order)
    {
        Console.WriteLine("Cannot ship the order. It has been canceled.");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine("Order is already canceled.");
    }
}