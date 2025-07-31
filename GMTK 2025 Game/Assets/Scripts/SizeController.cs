using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour
{
    public float timeScale;
    public float secondsBeforeSizeChange;
    
    private int scaleState;
    private void FixedUpdate()
    {
        if (timeScale > secondsBeforeSizeChange)
        {
            scaleState = 1;
            transform.localScale = new Vector3(0.3f, 0.45f, 0.3f);
        }
        if(timeScale < 0)
        {
            scaleState = 2;
            transform.localScale = new Vector3(0.1f, 0.15f, 0.1f);
        }


        if(scaleState == 1)
        {
            timeScale -= Time.deltaTime;
        }
        else if(scaleState == 2)
        {
            timeScale += Time.deltaTime;
        }
        else
        {
            timeScale += Time.deltaTime;
        }

    }
}
