using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class movement_ship : MonoBehaviour
{

    public float playerspeed = 1f;
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0f, -4f, 0);
    }

    // Update is called once per frame
    void Update()
    {

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

    }
}

