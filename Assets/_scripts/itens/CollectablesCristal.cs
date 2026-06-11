using UnityEngine;

public class CollectablesCristal : CollectablesBase
{

    public string playertag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playertag))
        {
            CollectCristal();
        }
    }


    protected override void CollectCristal()
    {
        base.CollectCristal();
      
    }


}

