using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RegenPlayer : MonoBehaviour
{
    public GameObject player;
    private void Update()
    {
        if(DeathZone.createNewPlayer)
        {
            Instantiate(player, transform.position, Quaternion.identity);
            DeathZone.createNewPlayer = false;
        }
    }
}
