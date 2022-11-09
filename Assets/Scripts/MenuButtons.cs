using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    GameObject mainMenu;
    GameObject howToPlayMenu;

    void Start()
    {
        mainMenu = GameObject.Find("MMCanvas");
        howToPlayMenu = GameObject.Find("HTPCanvas");
        howToPlayMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void HowToPlay()
    {
        howToPlayMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        howToPlayMenu.SetActive(false);
    }
}
