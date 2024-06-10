namespace DesignPatterns.Tests.Strategy;

using DesignPatterns.Strategy;
using FluentAssertions;
using Moq;

public class StrategyTests
{
    [Fact]
    public void GetTotal_WithPercentageDiscount_ShouldReturnNewTotal()
    {
        // Arrange
        var sale = new Sale(100, new PercentageDiscountPricingStrategy(10));

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(90);
    }

    [Theory]
    [InlineData("100", "100", "90")]
    [InlineData("100", "99", "99")]
    [InlineData("100", "101", "91")]
    public void AbsoluteDiscountOverThresholdStrategy(string threshold, string amount, string expectedResult)
    {
        // Arrange
        var absoluteDiscountOverThresholdStrategy = new AbsoluteDiscountOverThresholdStrategy(decimal.Parse(threshold), 10m);

        // Act
        var result = new Sale(decimal.Parse(amount), absoluteDiscountOverThresholdStrategy).GetTotal();

        // Assert
        result.Should().Be(decimal.Parse(expectedResult));
    }

    [Fact]
    public void GetTotal_WhenBefore12_ThenOneTimePercentageDiscount()
    {
        // Arrange
        var mockTime = new Mock<ISystemTime>();
        mockTime.Setup(x => x.Now).Returns(new DateTime(2024, 05, 27, 11, 59, 0));

        var strategy = new TimeDependentDiscountPricingStrategy(10, mockTime.Object);
        var sale = new Sale(100, strategy);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(90);
    }

    [Fact]
    public void GetTotal_WhenAfter12_ThenTwiceTimePercentageDiscount()
    {
        var timeMock = new Mock<TimeProvider>();
        timeMock.Setup(x => x.GetLocalNow()).Returns(new DateTime(2024, 05, 27, 12, 01, 0));

        var strategy = new TimeDependentDiscountPricingStrategy(10, timeMock.Object);
        var sale = new Sale(100, strategy);

        // Act
        var total = sale.GetTotal();

        // Assert
        total.Should().Be(80);
    }
}
