using UnityEngine;
using TMPro;
public class ItemManager : SingleTon<ItemManager>
{
    
    public SOint coins;
    public SOint cristals;
    public TextMeshProUGUI count;

    public static object Instance { get; internal set; }

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        cristals.value = 0;
    }


    public void AddCoin(int amount = 0)
    {
        coins.value += amount;
    }

    public void AddCristal(int amount = 0)
    {
        cristals.value += amount;
    }

}
