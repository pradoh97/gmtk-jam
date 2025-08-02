using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    public GameObject winScreen;
    public static bool winState;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winScreen.SetActive(true);
        winState = true;
    }
}
