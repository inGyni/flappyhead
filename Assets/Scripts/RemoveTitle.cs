using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTitle : MonoBehaviour
{
    // Script to Remove Title when you no longer see it, to free unneccesary memory)
    public GameObject title;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(title);
        Destroy(gameObject);
    }
}
