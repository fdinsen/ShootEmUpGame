using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{

    public float speed = 100;

    public Rigidbody rb;
    public BoxCollider bc;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();
    }


    void HandleMovement()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);

        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);

            }
            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);

        }
        else
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = new Vector2(rb.velocity.x, -speed);

            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
            }
        }
    }

}
