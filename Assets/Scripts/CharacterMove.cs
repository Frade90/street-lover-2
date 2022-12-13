using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float leftmove = 0.0f;
    public float rightmove = 0.0f;
    public float jump = 0.0f;
    public float jumpForce = 9.0f;

    

    [SerializeField]
    int private_numberi;

    public Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask groundLayer;

    void MovePlayer()
    {
        if (Input.GetKey("a"))
        {
            // move left:
            leftmove -= 0.001f;
            transform.Translate(leftmove, 0, 0);
        }
        // move right:
        if (Input.GetKey("d"))
        {
            rightmove += 0.001f;
            transform.Translate(rightmove, 0, 0);
        }
    }
    public bool IsGrounded()
    {
        // groundCheck.position antaa groundCheckin sijainnin. 4f on ympyr‰mitta, kuinka laajalta alueelta tarkistetaan
        // ground-alue ja ollaanko siihen kosketuksissa. groundLayer = lattiaksi asetettu gameObject, jolle on m‰‰ritelty
        // Layeriksi groundLayer
        return Physics2D.OverlapCircle(groundCheck.position, 4f, groundLayer);
    }
    void JumpPlayer()
    {
        if (IsGrounded())
        {
            
            if (Input.GetKeyDown("space")) // tai KeyCode.Space
            {
              
                //Debug.Log("Jumps");
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                //transform.Translate(0, jumpForce, 0);
            }
        }
    }

    void Update()
    {
        MovePlayer();
        JumpPlayer();
    }
    private void FixedUpdate()
    {
        
    }

}



