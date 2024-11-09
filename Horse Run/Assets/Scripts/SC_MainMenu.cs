using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    //private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, game SampleScene is initialized  
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
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
        //#if UNITY_EDITOR
        //UnityEditor.EditorApplication.isPlaying = false;

        //#endif
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
