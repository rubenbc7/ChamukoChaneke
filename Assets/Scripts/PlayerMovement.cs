  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    
    
    Rigidbody rb;
    public bool cubeGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float xMov = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        float yMov = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed ;

        //rb.velocity = new Vector3(xMov, 0, yMov) * speed;
        transform.Translate(xMov, 0 ,yMov);

        if(cubeGround == false ){
            rb.AddForce(new Vector3(0,-1f,0), ForceMode.Impulse);
        }

        if(Input.GetButtonDown("Jump") && cubeGround){
             rb.AddForce(new Vector3(0,50f,0), ForceMode.Impulse);
             cubeGround = false;
         }


        /*if (Input.GetKey("d")){
         rb.velocity = transform.right * 5;
        }
        if (Input.GetKey("a")){
         rb.velocity = -transform.right * 5;
        }*/
        
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Cube"){
            cubeGround = true;
        }
    }


}