using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject targetPrefab;
    private int targetRange;
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
        InvokeRepeating("SpawnTarget", startDelay, repeatRate);
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
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
            if (obstacleIndex == 0)
            {
                Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(20,0.5f,0), obstaclePrefabs[obstacleIndex].transform.rotation);
            }
            else if (obstacleIndex == 3)
            {
                Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(20,1,0), obstaclePrefabs[obstacleIndex].transform.rotation);
            }
            else
            {
                Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(20,0,0), obstaclePrefabs[obstacleIndex].transform.rotation);
            }
            //Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }

    void SpawnTarget()
    {
        if (!playerControllerScript.gameOver)
        {
            int targetRange = Random.Range(0,5);
            Instantiate(targetPrefab, new Vector3(20, targetRange, 0), targetPrefab.transform.rotation);
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
