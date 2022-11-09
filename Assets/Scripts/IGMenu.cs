using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IGMenu : MonoBehaviour
{
    bool gameIsPaused = false;
    GameObject pauseMenu;
    GameObject respawnMenu;
    GameObject deathMenu;
    GameObject winMenu;
    GameObject ingame;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform player;
    [SerializeField] AudioSource mainAudio, winAudio;
    GameObject enemies;

    void Start()
    {
        respawnMenu = GameObject.Find("RespawnMenu");
        pauseMenu = GameObject.Find("PauseMenu");
        deathMenu = GameObject.Find("DeathMenu");
        winMenu = GameObject.Find("GameWonMenu");
        ingame = GameObject.Find("ingameUI");
        enemies = GameObject.Find("Enemies");
        mainAudio.enabled = true;
        winAudio.enabled = false;
        ingame.SetActive(true);
        winMenu.SetActive(false);
        pauseMenu.SetActive(false);
        respawnMenu.SetActive(false);
        deathMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ResumeButton()
    {
        ResumeGame();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void RespawnButton()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        respawnMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        player.transform.position = spawnPoint.transform.position;
        Physics.SyncTransforms();
    }

    public void GameWon()
    {
        enemies.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        mainAudio.enabled = false;
        winAudio.enabled = true;
        winMenu.SetActive(true);
        ingame.SetActive(false);
    }
}
