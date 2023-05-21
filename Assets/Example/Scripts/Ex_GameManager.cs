using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_GameManager : MonoBehaviour
{
    public int coinNum;
    public GameObject gameOverScreen;
    public GameObject gameClearScreen;
    

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }
    
    public void GameClear()
    {
        Time.timeScale = 0f;
        gameClearScreen.SetActive(true);
    }
}
