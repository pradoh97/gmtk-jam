using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chekcpoint : MonoBehaviour
{
    private GameObject respawnZone;
    // Start is called before the first frame update
    void Start()
    {
        respawnZone = GameObject.FindWithTag("RespawnZone");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            respawnZone.transform.position = collision.gameObject.transform.position;
        }
    }
}
