using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float gameTimer = 10;

    private int _score = 0;
    private float _timer = 0;

    public int Score => _score;
    public float Timer => _timer;

    public event Action<int> OnScoreChanged;
    public event Action<float> OnTimerChanged;


    public void Game()
    {
        _score++;
        OnScoreChanged?.Invoke(_score);
    }

    public void Reset()
    {
        _score = 0;
        _timer = gameTimer;
    }

    public void UpdateTimer()
    {
        _timer -= Time.deltaTime;
        OnTimerChanged?.Invoke(_timer);
    }

    public void SetHighScore()
    {
        if (_score > GetHighScore())
            PlayerPrefs.SetInt("HighScore", _score);
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);
    }
}
