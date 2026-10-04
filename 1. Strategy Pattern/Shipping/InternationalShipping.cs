public class InternationalShipping : IshippingStrategy
{
    public decimal CalculateShippingCost(decimal weight, decimal distance)
    {
        // International shipping cost calculation logic
        return weight * distance * 1.0m; // Example calculation
    }
}