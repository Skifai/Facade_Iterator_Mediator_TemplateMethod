namespace DesignPatterns.Tests.Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Decorator;
    using DesignPatterns.Factory;
    using DesignPatterns.Strategy;
    using FluentAssertions;

    public class DecoratorTests
    {
        [Fact]
        public void GetTotal_Decorated()
        {
            // Arrange
            var strategy = new PercentageDiscountPricingStrategy(10);
            var sale = new Sale(100, new TimingDecorator(new BeforeAfterDecorator(strategy)));

            // Act
            var total = sale.GetTotal();

            // Assert
            total.Should().Be(90);


            var store = new WienerPizzaStore();
            var pizza = store.Create();
        }
    }
}
