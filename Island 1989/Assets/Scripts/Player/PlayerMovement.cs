using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Speed the player moves
    private float moveSpeed = 20f;

    //Determines if the player is grounded
    private bool isGrounded = false;

    //Updates Movement and Jumping
    void Update()
    {
        UpdateMovement();
        Jump();

        Debug.Log(isGrounded);
    }

    //Updates the player's movement
    void UpdateMovement()
    {
        //WSAD/Arrow keys for movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Lets the player move forward/backward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * z);
        //Lets the player move left/right
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * x);
    }

    //Updates jumping
    void Jump()
    {
        //If the player presses space, and is grounded, they will jump
        if(Input.GetButton("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 12f, 0f), ForceMode.Impulse);
        }
    }

    //If the player is on the ground, isGrounded is true
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    //If the player is NOT on the ground, isGrounded is false
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
