using UnityEngine;
using UnityEngine.UI;

public class powerup2 : MonoBehaviour
{
    public float powerspeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * powerspeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<movement_ship>().healdamge();
            Destroy(this.gameObject);

        }
    }
}
