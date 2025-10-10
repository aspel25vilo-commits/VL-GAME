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
            if (other.tag == "Enemy")
            {
                other.GetComponent<enemy>().enemythealth--;
                Debug.Log("Hit " + other.name);
                Instantiate(exs, transform.position, Quaternion.identity);

                Destroy(this.gameObject);
        }
            
        }
}