using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(0,0,20);
    public GameObject[] obstaclePrefabs;
    public int obstacleIndex;
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    public TextMeshProUGUI scoreText;
    private int score;
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        score = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            //int obstacleIndex = Random.Range(0,obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
    IEnumerator spawnTarget()
    {
        while (true)
        {
            UpdateScore(0);
        }
    }
    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
