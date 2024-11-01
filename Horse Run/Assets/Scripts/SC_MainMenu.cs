using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    //public GameObject Image;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        //MainMenu.SetActive(false);
        //CreditsMenu.SetActive(false);
        //Image.SetActive(false);
        gameManager.StartGame();
    }

    public void CreditsButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
