public class ShippingServices
{
    private IshippingStrategy _shippingStrategy;
    public ShippingServices(IshippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public decimal CalculateShippingCost(decimal weight, decimal distance)
    {
        return _shippingStrategy.CalculateShippingCost(weight, distance);
    }
}