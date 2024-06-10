namespace DesignPatterns.Strategy
{
    public interface ISalePricingStrategy
    {
        decimal GetTotal(Sale sale);
    }
}
