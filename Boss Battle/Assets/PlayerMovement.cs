using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class PlayerMovement : MonoBehaviour
{
    public CharacterMovement controller;// Referrencing CharacterMovement script. 
    //Note variables have to be used with an existing component or they will create an error.
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    float verticalMove = 0f;
    bool jump = false;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
          
        }
        else if (Input.GetButtonUp("Jump"))
        {
            jump = false;

        }
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
      
    }
    void FixedUpdate()
    {//This is used for player movement because it is smoother.
        
        controller.Move(horizontalMove * Time.deltaTime, false, jump);

    }
}
