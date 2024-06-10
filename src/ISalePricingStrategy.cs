namespace DesignPatterns
{
    public interface ISalePricingStrategy
    {
        decimal GetTotal(Sale sale);
    }
}
