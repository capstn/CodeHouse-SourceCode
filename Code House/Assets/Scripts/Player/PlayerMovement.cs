using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public LayerMask groundMask;
    public Transform groundCheck;
    public CharacterController controller;
    public GameObject dialogue;
    private Vector3 velocity;

    private bool canMove;
    public float speed = 1f;
    public float gravity = -18f;
    public float jumpHeight = 1f;
    public float groundDistance = 0.4f;
    bool isGrounded;

    private void Start() 
    {
        if (dialogue.activeSelf == true) 
        {
            Debug.Log("HELLO");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (dialogue.activeSelf == true) 
        {
            Debug.Log("HELLO");
        }


        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) 
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed  * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded) 
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
