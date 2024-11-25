using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Menu")]
    [SerializeField] private GameObject menuPage;
    [SerializeField] private TMP_Text txtHighScore;
    
    [Header("Game")]
    [SerializeField] private GameObject gamePage;
    [SerializeField] private TMP_Text txtScore;
    [SerializeField] private TMP_Text txtTimer;
    [SerializeField] private Image imgTimer;
    
    [Header("Game Over")]
    [SerializeField] private GameObject gameOverPage;
    [SerializeField] private TMP_Text txtFinalScore;

    public void ShowMenu()
    {
        menuPage.SetActive(true);
        gamePage.SetActive(false);
        gameOverPage.SetActive(false);
    }
    
    public void ShowGame()
    {
        menuPage.SetActive(false);
        gamePage.SetActive(true);
        gameOverPage.SetActive(false);
    }
    
    public void ShowGameOver(int score)
    {
        menuPage.SetActive(false);
        gamePage.SetActive(false);
        gameOverPage.SetActive(true);
    }
    
    public void SetMenuHighScore(int score)
    {
        txtHighScore.text = "High Score: " + score.ToString();
    }
    
    public void SetGameScore(int score)
    {
        txtScore.text = score.ToString();
    }
    
    public void SetGameTimer(float timer)
    {
        txtTimer.text = "Time: " + timer.ToString("0.00");
        imgTimer.fillAmount = timer / 10;
    }
    
    public void SetGameEndScore(int score, int highScore)
    {
        txtFinalScore.text = "Your Score: " + score.ToString();

        if (score > highScore)
        {
            txtFinalScore.text += "\n New HighScore!!";
        }
    }
}
