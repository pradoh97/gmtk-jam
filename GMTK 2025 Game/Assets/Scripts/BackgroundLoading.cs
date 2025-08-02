using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackgroundLoading : MonoBehaviour
{
    public GameObject backgroundObject;
    private SizeController sizeController;
    private Vector3 initialPosition;
    private float countdown;
   
    private void FixedUpdate()
    {
        initialPosition = new Vector3(backgroundObject.transform.position.x, backgroundObject.transform.position.y - 7.67f, backgroundObject.transform.position.z);

        sizeController = FindAnyObjectByType<SizeController>();

        countdown += Time.deltaTime;
        transform.position = Vector3.Lerp(initialPosition, backgroundObject.transform.position, countdown/sizeController.secondsBeforeSizeChange);

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
