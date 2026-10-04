public class RazorPayServices : IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} made using RazorPay.");
    }
}