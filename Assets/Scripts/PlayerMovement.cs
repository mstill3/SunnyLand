using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;

    // // Start is called before the first frame update
    // void Start() { }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // controller.Move();   
        // Debug.Log(horizontalMove);
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            Debug.Log("J");
        }
    }

    void FixedUpdate()
    {
        //move character
        // constant speed
        // Debug.Log(horizontalMove);
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
