using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    internal class PercentageDiscount : ISalePricingStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal GetTotal(Sale sale)
        {
            return sale.Amount - (sale.Amount / 100 * _percentage);
        }
    }
}
