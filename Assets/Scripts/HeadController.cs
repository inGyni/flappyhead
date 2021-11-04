using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeadController : MonoBehaviour
{

    #region Variables
    Rigidbody2D birdBody;
    public GameObject ReplayButton;
    public GameObject gameOver; 
    public Sprite spriteDead;
    public Text scoreText;
    public float speed;
    public float flapForce;
    bool dead = false;
    bool started = false; // boolean for checking if the game has started.
    int score = 0;

    #endregion

    #region Unity Functions

    void Start()
    {
        Time.timeScale = 0;
        birdBody = GetComponent<Rigidbody2D>();
        birdBody.velocity = Vector2.right * speed; // Set Initial velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !dead && started) // checks if primary mouse button is down, the player is not dead and if the game has started yet.
        {
            birdBody.velocity = Vector2.right * speed; // insuring the velocity stays the same over time.
            birdBody.AddForce(Vector2.up * flapForce); // add an upwards force to make the player jump
        }
    }

    #endregion

    #region Hooks

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Set the player as dead (score resetting not needing as we reload the scene);
        GetComponent<Animator>().SetBool("isDead", true);
        dead = true;
        // Display/Hide UI elements;
        ReplayButton.SetActive(true);
        gameOver.SetActive(true);
        GetComponent<SpriteRenderer>().sprite = spriteDead; // Set the player to a greyscale version of the sprite to add a death effect;
        // Move gameover text to the player's screen;
        gameOver.transform.position = new Vector3(gameObject.transform.position.x, gameOver.transform.position.y, gameOver.transform.position.z); 
        Time.timeScale = 0; // Pause the game until the player restart the round;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Change score after player has passed the obstacle;
        if (collision.gameObject.tag.Contains("Score"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    #endregion

    #region Functions
    public void Replay()
    {
        SceneManager.LoadScene(0); // Reload scene (everything will start from scratch);
    }
    public void StartRound()
    {
        started = true; // Set this to true so conditions work;
        Time.timeScale = 1; // Resume time;
    }

    #endregion
}
