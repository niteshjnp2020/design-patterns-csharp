public abstract class OrderProcessor
{
    public void ProcessOrder()
    {
        ValidateOrder();
        CalculatePrice();
        ProcessPayment();
        ShipOrder();
        SendNotification();
    }

    protected abstract void ValidateOrder();

    protected abstract void CalculatePrice();

    protected abstract void ProcessPayment();

    protected abstract void ShipOrder();

    protected virtual void SendNotification()
    {
        Console.WriteLine("Sending notification...");
    }
}