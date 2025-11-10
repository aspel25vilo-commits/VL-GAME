using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class movement_ship : MonoBehaviour
{
    public bool power;
    public float playerspeed = 1f;
    public int playerhealth = 1;

    public GameObject laserShot;
    public GameObject megalaser;
    public Vector3 spawnPosition;
    public Vector3 spawnPosition2;
    public Vector3 spawnPosition3;

    public GameObject txtobjc;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txtobjc = GameObject.Find("lifecounter");
        transform.position = new Vector3(0f, -4f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (power == true)
            {
                Instantiate(megalaser,new Vector3(transform.position.x,transform.position.y+5,0), Quaternion.identity);
                power = false;
            }
            else
            {
                Instantiate(laserShot, transform.position + spawnPosition, Quaternion.identity);
                Instantiate(laserShot, transform.position + spawnPosition2, Quaternion.identity);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
   
            moveY = -1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            
            moveX = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
            moveX = 1f;

        }
        Vector3 move = new Vector3(moveX, moveY, 0f).normalized;
        transform.Translate(move * playerspeed * Time.deltaTime);
        
        if (playerhealth < 1)
        {
            Destroy(this.gameObject);
        }

    }

    public void takedamge()
    {
        playerhealth--;
        if (playerhealth < 3)
        {
            Destroy(GameObject.Find("life3"));
        }
        if (playerhealth < 2)
        {
            Destroy(GameObject.Find("life2"));
        }
        if (playerhealth < 1)
        {
            Destroy(GameObject.Find("life1"));
        }
    }

   


    
    

    
}

