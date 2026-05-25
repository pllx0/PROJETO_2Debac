using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Vector3 direction;
    public float duration = 2f;
    public float side = 1;
    public int damage = 10;
    public string enemyTag = "Enemy";
    private void Awake()
    {
        Destroy(gameObject,duration);
    }



    void Update()
    {
        
        transform.Translate(direction * Time.deltaTime * side);
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(enemyTag))
        {
            Debug.Log("hit");
            Health enemyHealth = collision.gameObject.GetComponent<Health>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
                
            }
            Destroy(gameObject);
        }
    }


}
