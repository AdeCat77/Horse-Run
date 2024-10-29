using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 15;
    private PlayerController playerControllerScript;
    private float exitGame = -25;
    //private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < exitGame && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
