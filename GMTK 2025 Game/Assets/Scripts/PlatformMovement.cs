using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [Tooltip("False = Horizontal. True = Vertical")] public bool verticalMovement;
    public float distanceToTravel;
    public float timeToLoop;

    private float time;
    private Vector3 initialPos;
    private bool goLeftgoRight;
    private void Start()
    {
        initialPos = transform.position;
    }
    private void FixedUpdate()
    {
        if(time > timeToLoop)
        {
            goLeftgoRight = true;
        }
        else if(time < 0)
        {
            goLeftgoRight = false;
        }

        if (goLeftgoRight)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time += Time.deltaTime;
        }



        if (!verticalMovement)
        {
            transform.position = Vector3.Lerp(initialPos, new Vector3(initialPos.x + distanceToTravel, initialPos.y, initialPos.z), time / timeToLoop);
        }
        else
        {
            transform.position = Vector3.Lerp(initialPos, new Vector3(initialPos.x, initialPos.y + distanceToTravel, initialPos.z), time / timeToLoop);
        }
    }
}
