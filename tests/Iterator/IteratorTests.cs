using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator;
using FluentAssertions;

namespace DesignPatterns.Tests.Iterator
{
    public class IteratorTests
    {
        [Fact]
        public void IteratorByAmmount()
        {
            //Arrange
            var collection = new SaleCollection();
            collection.Add(new Sale(100,new PercentageDiscountPricingStrategy(50)));
            collection.Add(new Sale(90, new PercentageDiscountPricingStrategy(10)));
            collection.Add(new Sale(80, new PercentageDiscountPricingStrategy(10)));

            //Act
            var iterator = collection.CreateAmountIterator();
            
            var sale1 = iterator.GetNext();
            var sale2 = iterator.GetNext();
            var sale3 = iterator.GetNext();

            //Assert
            iterator.HasMore().Should().BeFalse();

            sale1.Amount.Should().Be(80);
            sale2.Amount.Should().Be(90);
            sale3.Amount.Should().Be(100);
        }

        [Fact]
        public void IteratorByTotal()
        {
            //Arrange
            var collection = new SaleCollection();
            collection.Add(new Sale(100, new PercentageDiscountPricingStrategy(50)));
            collection.Add(new Sale(90, new PercentageDiscountPricingStrategy(10)));
            collection.Add(new Sale(80, new PercentageDiscountPricingStrategy(10)));

            //Act
            var iterator = collection.CreateTotalIterator();

            var sale1 = iterator.GetNext();
            var sale2 = iterator.GetNext();
            var sale3 = iterator.GetNext();

            //Assert
            iterator.HasMore().Should().BeFalse();

            sale1.GetTotal().Should().Be(50);
            sale2.GetTotal().Should().Be(72);
            sale3.GetTotal().Should().Be(81);
        }
    }
}
