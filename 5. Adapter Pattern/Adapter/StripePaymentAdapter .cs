public class StripePaymentAdapter : IPaymentService
{
    private readonly StripeClient _stripeClient;

    public StripePaymentAdapter(StripeClient stripeClient)
    {
        _stripeClient = stripeClient;
    }

    public void Pay(decimal amount)
    {
        _stripeClient.MakePayment(amount);
    }
}