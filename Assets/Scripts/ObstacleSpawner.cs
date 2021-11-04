using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float minY;
    public float maxY;
    public float distance;
    public GameObject obstacle1;
    public GameObject obstacle2;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Obstacle1")
        {
            float obstacleY = Random.Range(minY, maxY); // Get random height
            Vector2 newPos = new Vector2(obstacle2.transform.position.x + distance, obstacleY); // Initialize a Vector2 position of obstacle 1 and add a predefined distance with a random Height;
            col.gameObject.transform.position = newPos; // Apply new Position;
        }
        else if(col.tag == "Obstacle2")
        {
            float obstacleY = Random.Range(minY, maxY); // Get random height
            Vector2 newPos = new Vector2(obstacle1.transform.position.x + distance, obstacleY); // Initialize a Vector2 position of obstacle 1 and add a predefined distance with a random Height;
            col.gameObject.transform.position = newPos; // Apply new Position;
        }
    }
}
