namespace Beverage
{
    public class Tea : IBeverage
    {
        public virtual double price()
        {
            return 1.5;
        }
    }
}