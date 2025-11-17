using UnityEngine;

public class wall : MonoBehaviour
{
    public GameObject exs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            other.GetComponent<movement_ship>().takedamge();
            Instantiate(exs, transform.position, Quaternion.identity);

        }
        if (other.tag == "mother")
        {
            other.GetComponent<movement_ship>().takedamge();
            Instantiate(exs, transform.position, Quaternion.identity);

        }
    }
   
}
