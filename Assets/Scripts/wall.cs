using UnityEngine;

public class wall : MonoBehaviour
{
    public GameObject player; 
    
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
            player.GetComponent<movement_ship>().takedamge();
        }
        if (other.tag == "mother")
        {
            player.GetComponent<movement_ship>().takedamge();
        }
        if (other.tag == "enemy2")
        {
            player.GetComponent<movement_ship>().takedamge();
        }
    }



}
