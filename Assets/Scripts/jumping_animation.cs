using UnityEngine;

public class jumping_animation : MonoBehaviour
{
    public Animator objAnimator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            objAnimator.resetTrigger("jump");

            objAnimator.setTrigger("jump");
        }
    }
}
