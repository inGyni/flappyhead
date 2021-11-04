using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    private bool isCollider = false;
    void Start()
    {
        if(gameObject.tag == "Obstacle")
        {
            isCollider = false;
        }
        else if(gameObject.tag == "ObstacleCollider")
        {
            isCollider = true;
        }
    }

    void Update()
    { 

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (isCollider)
        {
            //add to score
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isCollider)
        {
            // gameover
        }
    }
}
