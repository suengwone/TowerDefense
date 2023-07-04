using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UserBase : IUserBehavior
{
    public int cur;
    
    public abstract int Buy(int price, int cur);
    public abstract int Sell(int price, int cur);
    public abstract int Upgrade(int price, int cur);
}
