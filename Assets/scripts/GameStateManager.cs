using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private string gameStateKey = "GameState";
    public GameObject ob;

    private void OnApplicationPause(bool isPaused)
    {
        if (isPaused)
        {
            SaveGameState();
        }
        else
        {
            LoadGameState();
        }
    }

    private void LoadGameState()
    {
        int gameState = PlayerPrefs.GetInt(gameStateKey);
        if(gameState == 1)
        {
            
        }

    }

    private void SaveGameState()
    {
        PlayerPrefs.GetInt(gameStateKey, 1);
        
        PlayerPrefs.Save();
    }
}
