using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log(collision.transform.name);

        var health = collision.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
}
