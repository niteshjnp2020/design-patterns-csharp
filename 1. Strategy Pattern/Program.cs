// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IshippingStrategy shippingStrategy = new ExpressShipping();
var services = new ShippingServices(shippingStrategy);
decimal weight = 10.0m; // Example weight
decimal distance = 100.0m; // Example distance
decimal shippingCost = services.CalculateShippingCost(weight, distance);
Console.WriteLine($"Shipping Cost: {shippingCost}");