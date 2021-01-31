  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementChamuco : MonoBehaviour
{
    public float speed = 10f;
    
    public Animator anim;
    Rigidbody rb;

    public GameObject objetivo;

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

        anim.SetFloat("vertical", Input.GetAxis("Vertical"));

        //rb.velocity = new Vector3(xMov, 0, yMov) * speed;
        transform.Translate(xMov, -yMov, 0);
        /*if (Input.GetKey("d")){
         rb.velocity = transform.right * 5;
        }

        anim.SetBool("garrotazo", true);
            Destroy(objetivo);

        if (Input.GetKey("a")){
         rb.velocity = -transform.right * 5;
        }*/
        
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Chaneke")
        {
           Destroy(objetivo);
        }
    }


}