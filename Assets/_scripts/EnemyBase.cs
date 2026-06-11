using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 10;
    
    public Animator animator;
    public Health health;
    public string deathanimation = "Death";
    public string hitanimation = "Attack";
    



    private void Awake()
    {
        if (health != null) 
        {
            health.onDeath += Death;
        }

    }

    private void Death()
    {
        health.onDeath -= Death;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger(hitanimation);
        if (collision.transform.CompareTag("bullet"))
        {
            animator.SetTrigger(deathanimation);
            Destroy(gameObject, 1f);
        }


        var health = collision.transform.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
        
    }

   



}
