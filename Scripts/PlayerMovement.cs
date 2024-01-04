using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    public float forwardForce = 0.001f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        rb.AddForce(new Vector2(forwardForce, 0 * Time.deltaTime));

        if (Input.GetKey("w")) {
            rb.AddForce(new Vector2(0, 1000 * Time.deltaTime));
            
        }

        if (Input.GetKey("a")) {
            rb.AddForce(new Vector2(-5, 0 * Time.deltaTime));
            
        }
        if (Input.GetKey("d")) {
            rb.AddForce(new Vector2(5, 0 * Time.deltaTime));
            
        }

        if (Input.GetKey("s")) {
            rb.AddForce(new Vector2(0, -1000 * Time.deltaTime));
            
        }
    }
}
