using UnityEngine;
using System.Collections;


public class exs : MonoBehaviour
{
    private int count = 3;
    public float a = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(Countdown(0.2f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.localScale = new Vector3(transform.localScale.x * 0.8f, transform.localScale.y * 0.8f, 0);
        }
    }

    IEnumerator Countdown(float seconds)
    {
        while (count > 0)
        {
            // Display time here
            yield return new WaitForSeconds(seconds); // Wait for one second
            count--;
            transform.localScale = new Vector3(transform.localScale.x * 0.8f, transform.localScale.y * 0.8f, 0);
        }
        
        yield return null;
    }
}
