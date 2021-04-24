using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int isLose=0;
    private GameObject[] enemies;

    private void Start()
    {
        isLose = 0;
    }

    public void GameOver()
    {
        Debug.Log("game over");
        isLose = 1;
        Time.timeScale = 0;
    }
    public void YouWin()
    {
        Debug.Log("you win");
        isLose = 2;
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
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
