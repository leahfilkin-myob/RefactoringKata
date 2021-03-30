namespace Beverage
{
    public class HotChocolateWithCream : HotChocolate
    {
        public override double price()
        {
            return 1.45 + .15;
        }
    }
}