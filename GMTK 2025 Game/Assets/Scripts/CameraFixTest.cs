using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixTest : MonoBehaviour
{
    void Update()
    {
        Vector3 finalScale = new Vector3(1 / gameObject.transform.parent.localScale.x, 1 / gameObject.transform.parent.localScale.y, 1 / gameObject.transform.parent.localScale.z);
        gameObject.transform.localScale = finalScale;
    }
}
