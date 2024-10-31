using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject targetPrefab;
    private int targetRange;
    private float obstacleRange;
    private float startDelay = 0.5f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;
    //private GameManager gameManager;
    private int obstacleIndex;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnTarget", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
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
            float obstacleRange = Random.Range(30,40);
            if (obstacleIndex == 0)
            {
              Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(obstacleRange,0.5f,0), obstaclePrefabs[obstacleIndex].transform.rotation);
            }
            else if (obstacleIndex == 3)
            {
                Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(obstacleRange, 1, 0), obstaclePrefabs[obstacleIndex].transform.rotation);
            }
            else
            {
                Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(obstacleRange,0,0), obstaclePrefabs[obstacleIndex].transform.rotation);
            }
            
        }
    }

    void SpawnTarget()
    {
        if (!playerControllerScript.gameOver)
        {
            int targetRange = Random.Range(0,5);
            Instantiate(targetPrefab, new Vector3(25, targetRange, 0), targetPrefab.transform.rotation);
        }
    }
}
