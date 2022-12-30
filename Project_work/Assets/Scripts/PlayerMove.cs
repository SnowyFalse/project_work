using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float walkSpeed = 10f;
    [SerializeField] private float jumpPower = 5;

    private Vector2 moveInput;
    private Rigidbody rb;
    private bool isGrounded = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump(); 
        }
        
    }

    void Run()
    {
        Vector3 playerVelocity = new Vector3(moveInput.x * walkSpeed, rb.velocity.y, moveInput.y * walkSpeed);
        rb.velocity = transform.TransformDirection(playerVelocity);
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        isGrounded = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnMove( InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
