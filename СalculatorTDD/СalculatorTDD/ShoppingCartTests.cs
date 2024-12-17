using CalculatorTDD;
using Xunit;

public class ShoppingCartTests
{
    [Fact]
    public void CalculateTotal_ShouldReturnCorrectTotal_ForNonEmptyCart()
    {
        var cart = new ShoppingCart();
        cart.Items.Add(new CartItem { Name = "Item1", Price = 10, Quantity = 2 });
        cart.Items.Add(new CartItem { Name = "Item2", Price = 20, Quantity = 1 });

        var total = cart.CalculateTotal();

        Assert.Equal(40, total);
    }

    [Fact]
    public void CalculateTotal_ShouldReturnZero_ForEmptyCart()
    {
        var cart = new ShoppingCart();

        var total = cart.CalculateTotal();

        Assert.Equal(0, total);
    }
}