using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject playButton;
    public PlayerController playerController;
    public Text GameOverText;
    public Text Score;

    void Start()
    {
        playButton.SetActive(false);
    }

    public void UpdateScore()
    {
        var score_2 = (float)System.Math.Round(playerController.Score * 100f) / 100f;
        Score.text = "Score: " + score_2.ToString();
    }


    public void StartGame()
    {
        playerController.Score = 0;
        Time.timeScale = 1;
        UpdateScore();
        GameOverText.text = "";
        playButton.SetActive(false);
    }

    public void RestartGame()
    {
        GameOverText.text = "";
        EditorSceneManager.LoadScene(0);
        Time.timeScale = 1;
        playerController.Score = 0;
        playerController.isLost = false;
    }

    public void FinishGame()
    {
        Time.timeScale = 0;
        GameOverText.text = "Game Over!";
        playButton.SetActive(true);
    }

}
