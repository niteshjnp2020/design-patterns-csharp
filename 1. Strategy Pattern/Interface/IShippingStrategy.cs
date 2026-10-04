public interface IshippingStrategy
{
    decimal CalculateShippingCost(decimal weight, decimal distance);
}