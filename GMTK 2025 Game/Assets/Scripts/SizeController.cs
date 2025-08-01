using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour
{
    public float secondsBeforeSizeChange;

    [Header("Scale sizes")]
    public float scaleMultiplier1;
    public float scaleMultiplier2;
   

    private float timeTranscurred;
    private int scaleState;

    void goToNextScaleState(int nextState)
    {
        if (timeTranscurred > secondsBeforeSizeChange)
        {
            scaleState = nextState;
            timeTranscurred = 0;
        }
    }

    [Tooltip("make sure this remains the same number as the scale in the unity editor")] public Vector3 defaultScale = new Vector3(0.2f, 0.3f, 0.2f);
    private void FixedUpdate()
    {
        switch(scaleState)
        {
            case 0:
                transform.localScale = defaultScale * scaleMultiplier1;
                goToNextScaleState(1);
                break;
            case 1:
                transform.localScale = defaultScale * scaleMultiplier2;
                goToNextScaleState(0);
                break;
            default:
                break;
        }
    }
    private void LateUpdate()
    {
        timeTranscurred += Time.deltaTime;
    }
}
