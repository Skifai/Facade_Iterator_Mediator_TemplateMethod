using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Facade;
using FluentAssertions;

namespace DesignPatterns.Tests.Facade
{
    public class FacadeTests
    {
        [Fact]
        public void NoDiscount()
        {
            // Arrange
            var facade = new StrategyFacade();
            var sale = new Sale(100, facade);

            // Act
            var result = sale.GetTotal();

            // Asset
            result.Should().Be(100);
        }

        [Fact]
        public void PercentageDiscount()
        {
            // Arrange
            var facade = new StrategyFacade();
            var sale = new Sale(110, facade);

            // Act
            var result = sale.GetTotal();

            // Asset
            result.Should().Be(99);
        }
    }
}
