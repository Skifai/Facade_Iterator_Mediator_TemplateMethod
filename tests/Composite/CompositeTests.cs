namespace DesignPatterns.Tests.Composite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Composite;
    using DesignPatterns.Strategy;
    using FluentAssertions;

    public class CompositeTests
    {
        [Fact]
        public void BestForCustomerStrategy()
        {
            // Arrange
            var strategy1 = new AbsoluteDiscountOverThresholdStrategy(50, 12);
            var strategy2 = new PercentageDiscountPricingStrategy(10);
            var composite = new BestForCustomerStrategy();
            composite.Add(strategy1);
            composite.Add(strategy2);


            var sale = new Sale(100, composite);

            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(88);
        }

        [Fact]
        public void BestForStoreStrategy()
        {
            // Arrange
            var strategy1 = new AbsoluteDiscountOverThresholdStrategy(50, 12);
            var strategy2 = new PercentageDiscountPricingStrategy(10);
            var composite = new BestForStoreStrategy();
            composite.Add(strategy1);
            composite.Add(strategy2);

            var sale = new Sale(100, composite);

            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(88);
        }
    }
}
