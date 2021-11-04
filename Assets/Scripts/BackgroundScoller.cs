using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScoller : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.position += 2 * Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x; // Scroller for the background and ground to make it seem infinite.
        }
    }
}
