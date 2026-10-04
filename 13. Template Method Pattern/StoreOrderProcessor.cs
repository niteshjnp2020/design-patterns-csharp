public class StoreOrderProcessor : OrderProcessor
{
    protected override void ValidateOrder()
    {
        Console.WriteLine("Validating store order...");
    }

    protected override void CalculatePrice()
    {
        Console.WriteLine("Calculating store price...");
    }

    protected override void ProcessPayment()
    {
        Console.WriteLine("Processing cash/card payment...");
    }

    protected override void ShipOrder()
    {
        Console.WriteLine("Customer collects from store...");
    }
}