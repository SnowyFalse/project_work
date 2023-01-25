using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

        if (transform.position.y <= -30)
        {
            FindObjectOfType<AudioManager>().Play("Player Respawn");
            
            Debug.Log("Player died... Respawning");  
            transform.position = new Vector3(0, 1, 0);
        } 
        
    }

    void Run()
    {
        FindObjectOfType<AudioManager>().Play("Player Walk");
        Vector3 playerVelocity = new Vector3(moveInput.x * walkSpeed, rb.velocity.y, moveInput.y * walkSpeed);
        rb.velocity = transform.TransformDirection(playerVelocity);
        //FindObjectOfType<AudioManager>().Stop("Player Walk");
    }

    void Jump()
    {
        FindObjectOfType<AudioManager>().Play("Player Jump");
        rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        isGrounded = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Ground": 
                isGrounded = true;
                break;
            case "Object": 
                isGrounded = true;
                break;
            case "Goal":
                if (WinCounter.canWin)
                {
                    SceneManager.LoadScene(2);
                }
                else
                {
                    Debug.Log("You need to fulfill the win condition");
                }
                break;
        }
    }

    void OnMove( InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
