public class UserBase : IUserBehavior
{
    public int cur;

    public int Buy(int price)
    {
        if(price > cur)
        {
            // can't buy
            return cur;
        }
        else
        {
            // instantiate tower
            return cur - price;
        }
    }
    public int Sell(int price)
    {
        return cur + price;
    }
    public int Upgrade(int price)
    {
        if(price > cur)
        {
            // can't upgrade
            return cur;
        }
        else
        {
            // upgrade tower
            return cur - price;
        }
    }
}
