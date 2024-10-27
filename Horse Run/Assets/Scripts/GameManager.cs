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
    //public TextMeshProUGUI gameOverText;
    //public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }

    //public void GameOver()
    //{
        //gameOverText.gameObject.SetActive(true);
        //restartButton.gameObject.SetActive(true);
        //isGameActive = false;
    //}

    //public void RestartGame()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
