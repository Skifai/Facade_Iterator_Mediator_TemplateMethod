using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method
{
    public abstract class TemplateMethod : ISalePricingStrategy
    {
        public decimal GetTotal(Sale sale)
        {
            var total = ApplyDiscount(sale);
            total = ApplyTaxes(total);
            total = ApplyShiping(total);
            return total;
        }

        public abstract decimal ApplyShiping(decimal total);

        private decimal ApplyTaxes(decimal total)
        {
            return total * 2;
        }

        private decimal ApplyDiscount(Sale sale)
        {
            return sale.GetTotal();
        }
    }
}
