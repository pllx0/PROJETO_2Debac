using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public SO_playerconfig playerconfig;
    public Rigidbody2D rb;
    public Health _health;
    public Animator animator;
    private float currentespeed;
    void Update()
    {
        movementhvertical();
        movementhorizontal();
        
    }
    private void Awake()
    {
        if (_health != null)
        {
            _health.onDeath += onPlayerDeath;
        }
    }
    private void onPlayerDeath()
    { 
            _health.onDeath -= onPlayerDeath;
        animator.SetTrigger(playerconfig.deathanimation);
    }

    private void movementhorizontal()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentespeed = playerconfig.runspeed;
            animator.SetBool(playerconfig.sprintbool, true);
        }
        else
        {
            currentespeed = playerconfig.speed;
            animator.SetBool(playerconfig.sprintbool, false); 
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.linearVelocity = new Vector2(currentespeed, rb.linearVelocity.y);
            rb.transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool(playerconfig.runbool, true);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.linearVelocity = new Vector2(-currentespeed, rb.linearVelocity.y);
            rb.transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool(playerconfig.runbool, true);
        }
        else
        {
            animator.SetBool(playerconfig.runbool, false);
        }

        if (rb.linearVelocity.x > 0)
        {
            rb.linearVelocity -= playerconfig.friction;
        }
        else if (rb.linearVelocity.x < 0)
        {
            rb.linearVelocity += playerconfig.friction;
        }

        
    }
    private void movementhvertical()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * playerconfig.speed;
            animator.SetBool(playerconfig.jumpbool, true);
        }
        else
        {
            animator.SetBool(playerconfig.jumpbool, false);
        }


    }

   
}