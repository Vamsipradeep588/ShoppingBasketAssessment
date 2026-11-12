using Xunit;
using ShoppingBasket;

namespace ShoppingBasket.Tests;

public class ShoppingBasketCalculatorTests
{
    private readonly ShoppingBasketCalculator _calculator = new();

    [Fact]
    public void Empty_basket_returns_zero()
    {
        Assert.Equal(0, _calculator.CalculateTotalPence(Array.Empty<string>()));
    }

    [Theory]
    [InlineData("Apple", 35)]
    [InlineData("Banana", 20)]
    [InlineData("Melon", 50)]
    [InlineData("Lime", 15)]
    public void Single_item_uses_standard_price(string item, int expected)
    {
        Assert.Equal(expected, _calculator.CalculateTotalPence(new[] { item }));
    }

    [Theory]
    [InlineData(1, 50)]
    [InlineData(2, 50)]
    [InlineData(3, 100)]
    [InlineData(4, 100)]
    [InlineData(5, 150)]
    public void Melon_buy_one_get_one_free_offer_is_applied(int quantity, int expected)
    {
        Assert.Equal(expected, _calculator.CalculateTotalPence(Enumerable.Repeat("Melon", quantity)));
    }

    [Theory]
    [InlineData(1, 15)]
    [InlineData(2, 30)]
    [InlineData(3, 30)]
    [InlineData(4, 45)]
    [InlineData(5, 60)]
    [InlineData(6, 60)]
    [InlineData(7, 75)]
    public void Lime_three_for_two_offer_is_applied(int quantity, int expected)
    {
        Assert.Equal(expected, _calculator.CalculateTotalPence(Enumerable.Repeat("Lime", quantity)));
    }

    [Fact]
    public void Mixed_basket_is_totalled_correctly()
    {
        Assert.Equal(120, _calculator.CalculateTotalPence(
            new[] { "Apple", "Banana", "Melon", "Lime" }));
    }

    [Fact]
    public void Mixed_basket_applies_offers_independently()
    {
        Assert.Equal(80, _calculator.CalculateTotalPence(
            new[] { "Melon", "Melon", "Lime", "Lime", "Lime" }));
    }

    [Fact]
    public void Names_are_case_insensitive_and_whitespace_is_trimmed()
    {
        Assert.Equal(55, _calculator.CalculateTotalPence(new[] { " apple ", "BANANA" }));
    }

    [Fact]
    public void Unknown_item_throws_argument_exception()
    {
        Assert.Throws<ArgumentException>(() =>
            _calculator.CalculateTotalPence(new[] { "Orange" }));
    }

    [Fact]
    public void Null_basket_throws_argument_null_exception()
    {
        Assert.Throws<ArgumentNullException>(() =>
            _calculator.CalculateTotalPence(null));
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    public void Blank_item_throws_argument_exception(string item)
    {
        Assert.Throws<ArgumentException>(() =>
            _calculator.CalculateTotalPence(new[] { item }));
    }
}
