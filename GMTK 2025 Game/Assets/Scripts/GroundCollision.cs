using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerMovement.isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerMovement.isGrounded = false;
    }
}
