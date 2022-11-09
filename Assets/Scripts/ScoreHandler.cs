using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private static int pickupsCollected;

    private static int playerLives;


    void Start()
    {
        pickupsCollected = 0;
        playerLives = 3;
    }

    
    public int PickupsCollected
    {
        get
        {
            return pickupsCollected;
        }
        set
        {
            pickupsCollected = value;
        }
    } 

    public int PlayerLives
    {
        get
        {
            return playerLives;
        }
        set
        {
            playerLives = value;
        }
    } 
}
