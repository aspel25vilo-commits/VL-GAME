using UnityEngine;

public class megalaserscript : MonoBehaviour
{
        public float laserSpeed;
        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

            if (transform.position.y < -200 || transform.position.y > 200)
            {
                Destroy(this.gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "enemy")
            {
                other.GetComponent<enemy>().takedamge(10);
                Debug.Log("Hit" + other.name);
                
               
            }
            if (other.tag == "enemy2")
            {
                other.GetComponent<enemy2>().takedamge(10);
                Debug.Log("Hit" + other.name);


            }
        //other.GetComponent<movement_ship>().takedamge();


    }
}