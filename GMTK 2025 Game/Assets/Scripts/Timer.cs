using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timeText;
    public float time;

    public float minutes;
    public float seconds;

    void Start()
    {
        timeText = gameObject.GetComponent<Text>();
    }
    void FixedUpdate()
    {
        time += Time.deltaTime;
        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
