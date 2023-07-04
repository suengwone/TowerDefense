public interface IUserBehavior
{
    int Sell(int price, int cur);
    int Upgrade(int price, int cur);
    int Buy(int price, int cur);
}
