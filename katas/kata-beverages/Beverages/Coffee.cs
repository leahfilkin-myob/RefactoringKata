namespace Beverage
{
    public class Coffee : IBeverage
    {
        public virtual double price()
        {
            return 1.2;
        }
    }
}