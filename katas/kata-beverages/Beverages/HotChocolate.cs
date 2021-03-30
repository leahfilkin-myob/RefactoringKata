namespace Beverage
{
    public class HotChocolate : IBeverage
    {
        public virtual double price()
        {
            return 1.45;
        }
    }
}