using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Template_Method;
using FluentAssertions;

namespace DesignPatterns.Tests.Template_Method
{
    public class TemplatemethodTests
    {
        [Fact]
        public void FreeShiping()
        {
            //Arange
            var sale = new FreeShiping();

            //Act
            var result = sale.GetTotal(new Sale(100, new PercentageDiscountPricingStrategy(10)));

            //Assert
            result.Should().Be(180);
        }

        [Fact]
        public void FastShiping()
        {
            //Arange
            var sale = new FastShiping();

            //Act
            var result = sale.GetTotal(new Sale(100, new PercentageDiscountPricingStrategy(10)));

            //Assert
            result.Should().Be(200);
        }
    }
}
