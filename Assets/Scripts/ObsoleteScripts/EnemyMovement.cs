using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    public float leftmove = 0.0f;
    public float rightmove = 0.0f;
    public float jump = 0.0f;
    public float jumpForce = 9.0f;


    public Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask groundLayer;

    void Start()
    {
       
    }


   


    public bool IsGrounded()
    {
        
        return Physics2D.OverlapCircle(groundCheck.position, 4f, groundLayer);
    
  

    }
    void Update()
    {


        if (Input.GetKey("j"))
        {
            // move left:
            leftmove -= 0.0001f;
            // transform.position = new Vector3(leftmove, 0, 0);
            transform.Translate(leftmove, 0, 0);
            // transform.position = new Vector3(10f, 0, 0);
          
        }
        // move right:
        if (Input.GetKey("l"))
        {
            rightmove += 0.0001f;
            transform.Translate(rightmove, 0, 0);
            
        }
        // move up:
        if (IsGrounded())
        {
            if (Input.GetKeyDown("k")) // tai KeyCode.Space
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

                //jump += 10f;
                //transform.Translate(0, jump, 0);
            }
        }
    }
}
