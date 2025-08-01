using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoading : MonoBehaviour
{
    private SizeController sizeController;
    private Vector3 initialPosition;
    private float countdown;
    private void Start()
    {
        sizeController = FindAnyObjectByType<SizeController>();
        initialPosition = transform.position;
    }
    private void FixedUpdate()
    {
        countdown += Time.deltaTime;
        transform.position = Vector3.Lerp(initialPosition, new Vector3(0, 0.85f, 0), countdown/sizeController.secondsBeforeSizeChange);

        if(countdown > sizeController.secondsBeforeSizeChange)
        {
            countdown = 0;
        }
    }
}
