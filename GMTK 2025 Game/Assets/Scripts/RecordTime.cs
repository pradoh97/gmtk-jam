using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordTime : MonoBehaviour
{
    private Text timeText;

    private Timer timer;
    void Start()
    {
        timeText = gameObject.GetComponent<Text>();
        timer = FindAnyObjectByType<Timer>();
    }
    void FixedUpdate()
    {
        if(WinZone.winState)
        {
            timeText.text = string.Format("{0:00}:{1:00}", timer.minutes, timer.seconds);
            WinZone.winState = false;
        }
    }
}
