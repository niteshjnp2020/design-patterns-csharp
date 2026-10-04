public class PaymentProxy : IPaymentService
{
    private readonly IPaymentService _paymentService;

    public PaymentProxy(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Performing additional checks before processing payment...");
        _paymentService.ProcessPayment();
        Console.WriteLine("Payment processed through proxy.");
    }
}