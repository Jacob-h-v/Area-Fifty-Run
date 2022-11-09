using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetector : MonoBehaviour
{
    private GameObject scripty;
    private ScoreHandler scoreHandler;
    [SerializeField] GameObject respawnMenu;
    [SerializeField] GameObject deathMenu;
    [SerializeField] TMP_Text respawnText;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] TMP_Text pickupsCollected;
    [SerializeField] IGMenu igMenu;

    void Start()
    {
        scripty = GameObject.Find("ScriptyBoi");
        scoreHandler = scripty.GetComponent<ScoreHandler>();
    }

     void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            scoreHandler.PickupsCollected += 1;
            Debug.Log("Collected a PickUp. Total: " + scoreHandler.PickupsCollected + "/15");
            Destroy(collision.gameObject);
            UpdateUI();
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            KillPlayer();
        }
        
    }

    void KillPlayer()
    {
        scoreHandler.PlayerLives -= 1;
        if (scoreHandler.PlayerLives <= 0)
        {
            GameOver();
        }
        else
        {
            Respawn();
        }
    }

    void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        deathMenu.SetActive(true);
        Time.timeScale = 0f;
        gameOverText.SetText($"Game Over!\nYou managed to collect {scoreHandler.PickupsCollected}/15 meteor fragments. Try again?");
    }

    void Respawn()
    {
        respawnMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        if (scoreHandler.PlayerLives >= 2)
        {
            respawnText.SetText($"You died!\n{scoreHandler.PlayerLives} lives remaining");
        }
        if (scoreHandler.PlayerLives == 1)
        {
            respawnText.SetText($"You died!\n{scoreHandler.PlayerLives} life remaining");
        }
    }

    void UpdateUI()
    {
        pickupsCollected.SetText($"{scoreHandler.PickupsCollected}/15");
        if (scoreHandler.PickupsCollected == 15)
        {
            igMenu.GameWon();
        }
    }
}
