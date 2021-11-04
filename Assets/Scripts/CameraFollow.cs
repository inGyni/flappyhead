using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform birdTransform;

    void FixedUpdate()
    {
        transform.position = new Vector3(birdTransform.position.x, transform.position.y, transform.position.z);
    }
}
