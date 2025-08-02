using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TryAgain : MonoBehaviour, IPointerDownHandler
{
    private GameObject player;
    public GameObject winScreen;
    private Timer timer;

    void Start()
    {
        timer = FindAnyObjectByType<Timer>();
        player = FindAnyObjectByType<SizeController>().gameObject;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Destroy(player);
        DeathZone.createNewPlayer = true;
        winScreen.SetActive(false);
        timer.time = 0;
    }
}
