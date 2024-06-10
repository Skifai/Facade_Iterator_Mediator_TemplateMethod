namespace DesignPatterns.Composite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Strategy;

    public abstract class CompositePricingStrategy : ISalePricingStrategy
    {
        private readonly HashSet<ISalePricingStrategy> _strategies = [];

        protected IReadOnlyCollection<ISalePricingStrategy> PricingStrategies => _strategies;

        public void Add(ISalePricingStrategy strategy)
        {
            _strategies.Add(strategy);
        }

        public abstract decimal GetTotal(Sale sale);
    }

    public class BestForCustomerStrategy : CompositePricingStrategy
    {
        public override decimal GetTotal(Sale sale)
        {
            return PricingStrategies.Min(x => x.GetTotal(sale));
        }
    }

    public class BestForStoreStrategy : CompositePricingStrategy
    {
        public override decimal GetTotal(Sale sale)
        {
            return PricingStrategies.Max(x => x.GetTotal(sale));
        }
    }
}
