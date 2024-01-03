using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{   
    private int[] levels = { 1, 2, 3 };
    private int currentLevel = 1;
    private int latestPlayedLevel = 1;  // Initialize with the default level

    // private Text levelText;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Nyaa~ Welcome to the Nekomata Adventure Game! Let's have some fun, Master!");
        LoadLatestPlayedLevel();  // Load the latest played level from PlayerPrefs
        // UpdateLevelText();
    }

    void PlayLevel()
    {
        Debug.Log($"Nyaa~ Playing level {currentLevel}...");

        // Code for the gameplay goes here, Master! >w<
        // For now, let's assume you win.
        WinLevel();
    }

    void WinLevel()
    {
        Debug.Log($"Yay! Nyaa~ You've successfully conquered level {currentLevel}! Such a masterful player, Master!");

        // Save the latest played level
        latestPlayedLevel = currentLevel;
        PlayerPrefs.SetInt("LatestPlayedLevel", latestPlayedLevel);

        LoadStageSelector();  // Call a function to load the stage selector

        // UpdateLevelText();
    }

    // void UpdateLevelText()
    // {
    //     levelText.text = $"Level: {currentLevel}";
    // }

    public void RetryButton()
    {
        Debug.Log("Nyaa~ Master wants to retry the level! Let's go for it!");
        PlayLevel();  // Retry the current level
    }

    void LoadStageSelector()
    {
        // Load your stage selector scene here, Master!
        // For example:
        // SceneManager.LoadScene("StageSelectorScene");
    }

    void LoadLatestPlayedLevel()
    {
        // Load the latest played level from PlayerPrefs
        latestPlayedLevel = PlayerPrefs.GetInt("LatestPlayedLevel", 1);

        // Set the current level to the latest played level
        currentLevel = latestPlayedLevel;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
