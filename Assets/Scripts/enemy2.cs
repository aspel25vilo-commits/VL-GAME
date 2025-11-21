using System.Collections;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public int enemythealth;
    public float enemyspeed = 1f;
    public GameObject txtobj;
    public GameObject exs;
    public bool intmove = true;
    public Animator objAnimator;
    

    private Vector3 movement = Vector3.zero;
    void Start()
    {
        txtobj = GameObject.Find("pointcounter");
        StartCoroutine(Enmove());
    }
    private void Awake()
    {
        transform.localScale = new Vector3(0.76f, 1.1f, 1f);
    }


    void Update()
    {
        
        if (intmove == false)
        {    
            transform.Translate(movement.normalized * enemyspeed * Time.deltaTime); 
        }
        if (enemythealth < 1)
        {
            txtobj.GetComponent<point>().addpoints(2);
            Destroy(this.gameObject);
            Instantiate(exs, transform.position, Quaternion.identity);
        }
           
    }
    IEnumerator Enmove()
    {
        while (true)
        {
            if (intmove == true)
            {
                yield return new WaitForSeconds(1f);
                intmove = false;
            }
            int rull = 0;
            while (rull == 0)
            {
                rull = Random.Range(-1, 2);
            }

            movement.x = rull;
            movement.y = -1;
            yield return new WaitForSeconds(1f);
        }

    }
    public void takedamge(int dgtotake)
    {
        
        enemythealth-=dgtotake;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<movement_ship>().takedamge();
            Destroy(gameObject);
            Instantiate(exs, transform.position, Quaternion.identity);
            
        }
    }
}

