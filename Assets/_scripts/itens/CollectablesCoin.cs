using UnityEngine;

public class CollectablesCoin : CollectablesBase
{
    protected override void Collect()
    {
        base.Collect();
        ItemManager.instance.AddCoin();

    }


}

