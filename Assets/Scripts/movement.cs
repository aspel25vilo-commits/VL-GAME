using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{

    public float playerspeed = 1f;
    public float jumpspeed = 1f;
    Rigidbody2D fysik;
    Animator objAnimator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0f, -4f, 0);
        fysik = GetComponent<Rigidbody2D>();
        objAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            fysik.AddForce(Vector3.up * jumpspeed);
            objAnimator.SetBool("isJumping", true);
        }
        else
        {
            objAnimator.SetBool("isJumping", false);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerspeed);

        }

    }
}

