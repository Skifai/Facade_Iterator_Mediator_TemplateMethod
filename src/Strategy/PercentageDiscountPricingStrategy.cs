namespace DesignPatterns.Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PercentageDiscountPricingStrategy : ISalePricingStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscountPricingStrategy(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal GetTotal(Sale sale)
        {
            return sale.Amount - sale.Amount / 100 * _percentage;
        }
    }
}
