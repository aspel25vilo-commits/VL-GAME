using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class movement_ship : MonoBehaviour
{

    public float playerspeed = 1f;
    public int playerhealth = 1;

    public GameObject laserShot;
    public Vector3 spawnPosition;
    public Vector3 spawnPosition2;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0f, -4f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(laserShot, transform.position + spawnPosition, Quaternion.identity);
            Instantiate(laserShot, transform.position + spawnPosition2, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerspeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerspeed);
        }
        if (playerhealth < 1)
        {
            Destroy(this.gameObject);
        }

    }

    public void takedamge()
    {
        playerhealth--;
    }


    
    

    
}

