using UnityEngine;


public class exs : MonoBehaviour

{

    public float a = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
