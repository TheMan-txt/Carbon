using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   private Rigidbody2D body;
    private bool currentParam;
    private Animator anim;
    [SerializeField] public Collider2D groundCollider;

    [SerializeField] float speed;
    [SerializeField] float jumpForce;

    // Awake is called when the script is loaded.
    private void Awake()
    {   //These grab the components of the Object/Player
        body=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();

    }

    // Update is called once per fixed timestep.
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        //Sets horizontal velocity every Fixed Timestep
        body.velocity=new Vector2((horizontalInput*speed),body.velocity.y);

        //If space is pressed and the player is touching the ground apply jumpforce in the vertical axis.
        //Note that body.velocity just means we are accessing the velocity property of the object.
        if(Input.GetKey(KeyCode.Space) && body.IsTouching(groundCollider))
        {
            body.velocity=new Vector2(body.velocity.x,jumpForce);

        }

        if(horizontalInput > 0.01f)
        {   
            
            body.transform.localScale = new Vector3(1,1,1);

        }

        else if(horizontalInput < -0.01f)
        {   

            body.transform.localScale = new Vector3(-1,1,1);

        }

        //Set Animator Parameter
        anim.SetBool("run",horizontalInput != 0);

        
    }
}
