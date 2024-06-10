namespace DesignPatterns.Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Strategy;

    public class BeforeAfterDecorator : ISalePricingStrategy
    {
        private readonly ISalePricingStrategy _salePricingStrategy;

        public BeforeAfterDecorator(ISalePricingStrategy salePricingStrategy)
        {
            _salePricingStrategy = salePricingStrategy;
        }

        public decimal GetTotal(Sale sale)
        {
            Console.WriteLine($"Old Total: {sale.Amount}");
            var newTotal = _salePricingStrategy.GetTotal(sale);
            Console.WriteLine($"New Total: {newTotal}");
            return newTotal;
        }
    }

    public class TimingDecorator : ISalePricingStrategy
    {
        private readonly ISalePricingStrategy _salePricingStrategy;

        public TimingDecorator(ISalePricingStrategy salePricingStrategy)
        {
            _salePricingStrategy = salePricingStrategy;
        }

        public decimal GetTotal(Sale sale)
        {
            var swatch = Stopwatch.StartNew();
            try
            {
                return _salePricingStrategy.GetTotal(sale);
            }
            finally
            {
                var time = swatch.Elapsed;
                Console.WriteLine(time.TotalMilliseconds);
            }
        }
    }
}
