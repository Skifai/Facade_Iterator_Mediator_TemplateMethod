using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy;

namespace DesignPatterns.Facade
{
    public class StrategyFacade : ISalePricingStrategy
    {
        public decimal GetTotal(Sale sale)
        {
            if (sale.Amount <= 100)
            {
                var strategy = new NoDiscount();
                return strategy.GetTotal(sale);
            }
            else
            {
                var strategy = new PercentageDiscount(10m);
                return strategy.GetTotal(sale);
            }
        }
    }
}
