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
    public Animator animator;
    public string runbool = "running";
    public string sprintbool = "sprint";
    public string jumpbool = "jump";
    

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
            animator.SetBool(sprintbool, true);
        }
        else
        {
            currentespeed = speed;
            animator.SetBool(sprintbool, false); 
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.linearVelocity = new Vector2(currentespeed, rb.linearVelocity.y);
            rb.transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool(runbool, true);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.linearVelocity = new Vector2(-currentespeed, rb.linearVelocity.y);
            rb.transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool(runbool, true);
        }
        else
        {
            animator.SetBool(runbool, false);
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
            animator.SetBool(jumpbool, true);
        }
        else
        {
            animator.SetBool(jumpbool, false);
        }


    }

   
}