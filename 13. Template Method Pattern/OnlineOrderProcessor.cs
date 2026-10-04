public class OnlineOrderProcessor : OrderProcessor
{
    protected override void ValidateOrder()
    {
        Console.WriteLine("Validating online order...");
    }

    protected override void CalculatePrice()
    {
        Console.WriteLine("Calculating online order price...");
    }

    protected override void ProcessPayment()
    {
        Console.WriteLine("Processing online payment...");
    }

    protected override void ShipOrder()
    {
        Console.WriteLine("Shipping through courier...");
    }
}