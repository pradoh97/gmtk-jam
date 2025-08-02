using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private GameObject respawnZone; //please only use one per level
    public static bool createNewPlayer;
    private void Start()
    {
        respawnZone = GameObject.FindWithTag("RespawnZone");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            createNewPlayer = true;
        }
    }
}
