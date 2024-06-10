namespace DesignPatterns.Tests.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Factory;
    using DesignPatterns.Strategy;

    public class FactoryTests
    {
        [Fact]
        public void CreateByName()
        {
            var strategy = PricingStrategyFactory.Create("AbsoluteDiscountOverThreshold", 50m, 10m);
            var sale = new Sale(100, strategy);

            sale.GetTotal();
        }
    }
}
