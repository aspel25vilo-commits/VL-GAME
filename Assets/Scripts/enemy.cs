using UnityEngine;

public class enemy : MonoBehaviour
{
    public int enemythealth;
    public float enemyspeed = 1f;
    public GameObject txtobj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txtobj = GameObject.Find("pointcounter");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemyspeed * Time.deltaTime);

        if (enemythealth < 1)
        {
            txtobj.GetComponent<point>().addpoints(1);
            Destroy(this.gameObject);
        }
            
        




    }
    public void takedamge()
    {
        
        enemythealth--;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.tag == "laser")
        {
            Destroy(this.gameObject);
        }*/
    }
}

