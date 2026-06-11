using System.Collections;
using System.Threading;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    public ProjectileBase projectile;
    public Transform shootOrigin;
    public float fireRate = 0.1f;
    private Coroutine _currentCoroutine;
    public Transform playerside;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _currentCoroutine = StartCoroutine(ShootCoroutine());
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (_currentCoroutine != null)

                StopCoroutine(_currentCoroutine);

        }

    }

    IEnumerator ShootCoroutine()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(fireRate);
        }
    }


    public void Shoot()
    {
        var newProjectile = Instantiate(projectile);
        newProjectile.transform.position = shootOrigin.position;
        newProjectile.side = playerside.localScale.x;

    }

    
}