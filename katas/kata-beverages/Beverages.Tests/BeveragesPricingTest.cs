using System;
using Beverage;
using Xunit;

namespace Beverages.Tests
{
    public class BeveragesPricingTest
    {
        const int PRECISION = 2;

        [Fact]
        public void computes_coffee_price()
        {
            IBeverage coffee = new Coffee();
            Assert.Equal(1.20, coffee.price(), PRECISION);
        }

        [Fact]
        public void computes_tea_price()
        {
            IBeverage tea = new Tea();
            Assert.Equal(1.50, tea.price(), PRECISION);
        }

        [Fact]
        public void computes_hot_chocolate_price()
        {
            IBeverage hotChocolate = new HotChocolate();
            Assert.Equal(1.45, hotChocolate.price(), PRECISION);
        }

        [Fact]
        public void computes_tea_with_milk_price()
        {
            Tea teaWithMilk = new TeaWithMilk();
            Assert.Equal(1.6, teaWithMilk.price(), PRECISION);
        }

        [Fact]
        public void computes_coffee_with_milk_price()
        {
            Coffee coffeeWithMilk = new CoffeeWithMilk();
            Assert.Equal(1.3, coffeeWithMilk.price(), PRECISION);
        }

        [Fact]
        public void computes_hot_chocolate_with_cream_price()
        {
            HotChocolateWithCream hotChocolateWithCream = new HotChocolateWithCream();
            Assert.Equal(1.6, hotChocolateWithCream.price(), PRECISION);
        }

        [Fact]
        public void computes_coffee_with_milk_and_cream_price()
        {
            Coffee coffeeWithMilkAndCream = new CoffeeWithMilkAndCream();
            Assert.Equal(1.45, coffeeWithMilkAndCream.price(), PRECISION);
        }
    }
}
