using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    private GameObject[] enemies;
    public void GameOver()
    {
        Debug.Log("game over");
        Time.timeScale = 0;
    }
    public void YouWin()
    {
        Debug.Log("you win");
        Time.timeScale = 0;
    }
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            YouWin();

        }
    }
}
