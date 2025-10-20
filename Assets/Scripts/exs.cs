using UnityEngine;
using System.Collections;


public class exs : MonoBehaviour
{
    private int count = 160;
    public float a = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(Countdown(0.05f));
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator Countdown(float seconds)
    {
        while (count > 0)
        {
            // Display time here
            yield return new WaitForSeconds(seconds); // Wait for one second
            count--;
            transform.localScale = new Vector3(transform.localScale.x * 0.96f, transform.localScale.y * 0.96f, 0);

        }
        
        yield return null;
    }
}
