using UnityEngine;


public class CollectablesBase : MonoBehaviour
{

    public string playertag = "Player";
    public ItemManager itemManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playertag))
        {
            Collect();
        }
    }




    protected virtual void Collect()
    {
        Debug.Log("collected");
        gameObject.SetActive(false);
        OnCollect();
    }

    protected virtual void OnCollect()
    {
        itemManager.AddCoin(1);
    }




}
