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
        initialPosition = transform.position;
    }
    private void FixedUpdate()
    {
        sizeController = FindAnyObjectByType<SizeController>();

        countdown += Time.deltaTime;
        transform.position = Vector3.Lerp(initialPosition, new Vector3(0, 0.85f, 0), countdown/sizeController.secondsBeforeSizeChange);

        if(countdown > sizeController.secondsBeforeSizeChange)
        {
            countdown = 0;
        }
        if(PlayerMovement.iveBeenDestroyed)
        {
            countdown = 0;
        }
    }
}
