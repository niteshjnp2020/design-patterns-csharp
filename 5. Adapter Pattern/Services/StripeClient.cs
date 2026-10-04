public class StripeClient
{
    public void MakePayment(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} made using Stripe.");
    }
}