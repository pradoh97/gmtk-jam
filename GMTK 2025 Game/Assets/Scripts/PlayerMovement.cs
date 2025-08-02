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
    public static bool iveBeenDestroyed;

    private bool jumping;
    private bool jumpCancelled;
    public bool isGrounded;

    void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !jumping)
        {
            rb.AddForce(Vector2.up * (jumpHeight * 100));
            jumping = true;
            jumpCancelled = false;
        }

        if (jumping)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jumpCancelled = true;
            }

            if (isGrounded)
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
    private void OnDestroy()
    {
        iveBeenDestroyed = true;
    }
    private void Start()
    {
        StartCoroutine(waitAFrameBeforeUpdatingVar());
    }
    IEnumerator waitAFrameBeforeUpdatingVar()
    {
        yield return new WaitForSeconds(Time.deltaTime);
        iveBeenDestroyed = false;
    }
}
