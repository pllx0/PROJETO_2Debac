using UnityEngine;

public class ItemManager : SingleTon<ItemManager>
{
    
    public int coins;
    
    

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins = 0;
    }


    public void AddCoin(int amount = 1)
    {
        coins += amount;
    }


}
