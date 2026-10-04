public class NormalShipping : IshippingStrategy
{
    public decimal CalculateShippingCost(decimal weight, decimal distance)
    {
        // Normal shipping cost calculation logic
        return weight * distance * 0.5m; // Example calculation
    }
}