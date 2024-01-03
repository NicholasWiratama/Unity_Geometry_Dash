using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{   
    public string[] levelScenes = { "Level1", "Level2", "Level3" };
    private int currentLevelIndex = 0;

    public void Level1()
    {
        currentLevelIndex = 1;
        SceneManager.LoadScene(levelScenes[currentLevelIndex]);
    }

    public void Level2()
    {
        currentLevelIndex = 2;
        SceneManager.LoadScene(levelScenes[currentLevelIndex]);
    }

    public void Level3()
    {
        currentLevelIndex = 3;
        SceneManager.LoadScene(levelScenes[currentLevelIndex]);
    }

    public void RetryLevel()
    {
        // Reload the current level
        SceneManager.LoadScene(levelScenes[currentLevelIndex]);
    }

    public void Continue()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
