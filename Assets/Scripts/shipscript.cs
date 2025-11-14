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
    private GameObject life3;
    private GameObject life2;
    private GameObject life1;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        txtobjc = GameObject.Find("lifecounter");
        transform.position = new Vector3(0f, -4f, 0);
        
    }
    private void Awake()
    {
        life3 = GameObject.Find("life3");
        life2 = GameObject.Find("life2");
        life1 = GameObject.Find("life1");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerhealth > 3)
        {
            playerhealth = 3;
        }
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
            life3.SetActive(false);
        }
        if (playerhealth < 2)
        {
            life2.SetActive(false);
        }
        if (playerhealth < 1)
        {
            life1.SetActive(false);
        }
    }

    public void healdamge()
    {
        playerhealth = 3;
        if (playerhealth == 1)
        {
            life1.SetActive(true);
        }
        if (playerhealth == 2) 
        {
            life2.SetActive(true);
        }
        if (playerhealth == 3)
        {
            life3.SetActive(true);
        }
    }









}

