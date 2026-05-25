using UnityEngine;
using TMPro;
public class ItemManager : SingleTon<ItemManager>
{
    
    public int coins;
    public TextMeshProUGUI count;

    public static object Instance { get; internal set; }

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins = 0;
    }


    public void AddCoin(int amount = 0)
    {
        coins += amount;
        count.text = coins.ToString();
    }

    
}
