using UnityEngine;


public class CollectablesBase : MonoBehaviour
{

    public ItemManager itemManager;
    




    protected virtual void CollectCoin()
    {
        Debug.Log("collected");
        gameObject.SetActive(false);
        OnCollectCoin();
        
    }

    protected virtual void OnCollectCoin()
    {
        itemManager.AddCoin(1);
    }

    protected virtual void CollectCristal()
    {
        Debug.Log("collected");
        gameObject.SetActive(false);
        OnCollectCristal();

    }


    protected virtual void OnCollectCristal()
    {
        itemManager.AddCristal(1);
    }



}
