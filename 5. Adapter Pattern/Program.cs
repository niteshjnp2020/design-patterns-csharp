// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IPaymentService razorPayService = new RazorPayServices();
razorPayService.Pay(100);

IPaymentService stripePaymentService = new StripePaymentAdapter(new StripeClient());
stripePaymentService.Pay(200);
