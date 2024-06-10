using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    internal class NoDiscount : ISalePricingStrategy
    {
        public decimal GetTotal(Sale sale)
        {
            return sale.Amount;
        }
    }
}
