using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float xMov = Input.GetAxisRaw("Horizontal");
        float yMov = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xMov, rb.velocity.y, yMov) * speed;


        /*if (Input.GetKey("d")){
         rb.velocity = transform.right * 5;
        }

        if (Input.GetKey("a")){
         rb.velocity = -transform.right * 5;
        }*/
        
    }
}
