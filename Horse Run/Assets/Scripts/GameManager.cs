using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    private Button button;
    public bool isGameActive;
    public GameObject titleScreen;
    public GameObject mainmenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        //button = GetComponent<Button>();
        //button.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    //private IEnumerator SpawnApple()
    //{
        //while (isGameActive)
        //{
            //yield return new WaitForSeconds(spawnRate);
            //float appleRange = Random.Range(0,6); 
            //Instantiate(apple);
        //}
    //}

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }
      
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
    
    public void StartGame()
    {
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        isGameActive = true;
        //StartCoroutine();
        mainmenuCanvas.SetActive(false);
    }
}
