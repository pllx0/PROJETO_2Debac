using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 friction = new Vector2(.1f, 0);
    public float speed;
    public float runspeed;

    private float currentespeed;

    void Update()
    {
        movementhvertical();
        movementhorizontal();
    }



    private void movementhorizontal()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentespeed = runspeed;
        }
        else
        {
            currentespeed = speed;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.linearVelocity = new Vector2(currentespeed, rb.linearVelocity.y);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.linearVelocity = new Vector2(-currentespeed, rb.linearVelocity.y);
        }

        if (rb.linearVelocity.x > 0)
        {
            rb.linearVelocity -= friction;
        }
        else if (rb.linearVelocity.x < 0)
        {
            rb.linearVelocity += friction;
        }

        
    }
    private void movementhvertical()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * speed;
        }
    }
}