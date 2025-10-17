using UnityEngine;

public class playeranimation : MonoBehaviour
{
    public Animator objAnimator;
    private SpriteRenderer fhillip;
    private void Start()
    {
        objAnimator = GetComponent<Animator>();
        fhillip = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            fhillip.flipX = false;
            objAnimator.SetBool("runleft", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            fhillip.flipX = true;
            objAnimator.SetBool("runleft", true);
        }
        else
        {
            objAnimator.SetBool("runleft", false);
        }
    }

}

