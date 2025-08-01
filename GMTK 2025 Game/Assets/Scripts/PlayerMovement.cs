using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Adjustments: jump")]
    public float jumpButtonHoldTime = 0.5f;
    public float jumpHeight = 5;
    public float jumpCancelRate = 100;

    [Header("Adjustments: movement")]
    public float characterSpeed = 1000;

    [Header("necessary stuff")]
    public Rigidbody2D rb;
    public Collider2D groundDetection;

    private float jumpTime;
    private bool jumping;
    private bool jumpCancelled;
    public bool isGrounded;

    void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb.gravityScale/2));
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            jumping = true;
            jumpCancelled = false;
            jumpTime = 0;	
        }

        if (jumping)
        {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jumpCancelled = true;
            }

            if (jumpTime > jumpButtonHoldTime)
            {
                jumping = false;
            }
        }
    }
    void leftRightMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * characterSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * characterSpeed);
        }
        if(!Input.anyKey)
        {
            rb.totalForce = Vector2.zero;
        }
    }
    private void Update()
    {
        Jumping();

    }

    private void FixedUpdate()
    {
        leftRightMovement();
        if (jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * jumpCancelRate);
        }
    }
}
