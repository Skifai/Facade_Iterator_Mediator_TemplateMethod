namespace DesignPatterns.Tests;

using FluentAssertions;

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
}
