using UnityEngine;

public class laser : MonoBehaviour
{
        public float laserSpeed;
        public GameObject exs;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

            if (transform.position.y < -10 || transform.position.y > 10)
            {
                Destroy(this.gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "enemy")
            {
                other.GetComponent<enemy>().takedamge(1);
                Debug.Log("Hit" + other.name);
                Instantiate(exs, transform.position, Quaternion.identity);
                


            Destroy(this.gameObject);


            }
            if (other.tag == "enemy2")
            {
                other.GetComponent<enemy2>().takedamge(1);
                Debug.Log("Hit" + other.name);
                Instantiate(exs, transform.position, Quaternion.identity);



                Destroy(this.gameObject);
            }
        if (other.tag == "mother")
        {
            other.GetComponent<mother>().takedamge(1);
            Debug.Log("Hit" + other.name);
            Instantiate(exs, transform.position, Quaternion.identity);



            Destroy(this.gameObject);
        }


    }
       




}