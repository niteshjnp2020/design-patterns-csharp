public class ExpressShipping : IshippingStrategy
{
    public decimal CalculateShippingCost(decimal weight, decimal distance)
    {        
        return weight * distance * 2.0m; 
    }
}