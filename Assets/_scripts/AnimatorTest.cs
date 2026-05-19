using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    public Animator animator;
    public string triggerName = "fly";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger(triggerName);
        }
    }
}