
namespace Beverage
{
    public class CoffeeWithMilk : Coffee
    {
        public override double price()
        {
            return base.price() + 0.1;
        }
    }
}