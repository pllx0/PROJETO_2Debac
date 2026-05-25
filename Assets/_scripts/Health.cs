using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int startlife = 10;
    private int _currentlife;
    private bool _isAlive;
    public Action onDeath;
    
    private void Awake()
    {
       Init();
    }


    private void Init()
    {
        _isAlive = true;
        _currentlife = startlife;
    }
    public void TakeDamage(int damage)
    {
        if ( _isAlive == false) return;

        _currentlife -= damage;

        if (_currentlife <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        _isAlive = false;
        Destroy(gameObject, 1f);

        onDeath?.Invoke();


    }


}
