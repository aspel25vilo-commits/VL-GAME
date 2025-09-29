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
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 20f;
    
    public float targetTime = 60.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0f, -4f, 0);
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { targetTime -= Time.deltaTime;
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerspeed);
        }
        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.AddForce(Vector3.up * jumpspeed);
        }
    }
}
