﻿using UnityEngine;

public class BallController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 4.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    private float jump = 4.0f;

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        moveVector = Vector3.zero;

        if (controller.isGrounded) {
            verticalVelocity = -0.5f;
        }
        else {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        
        // X - Left and Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

        // Y - Up and Down
        if (Input.GetKeyDown(KeyCode.W) && controller.isGrounded)
        {
            verticalVelocity = jump;
        }
        moveVector.y = verticalVelocity;
        
        // Z - Forward and Backward
        moveVector.z = speed;
        
        controller.Move (moveVector * Time.deltaTime);
               
	}


}
