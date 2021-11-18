using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Boll _boll;
    [SerializeField] private CoinGenerator _coinGenerator;
    [SerializeField] private CactusGenerator _cactusGenerator;
    [SerializeField] private GameOverScreen _gameOverScreen;

    private void OnEnable()
    {
        _gameOverScreen.RestartButtonClick += OnRestartButtonClick;
        _boll.GameOver += OnGameOver;
    }
    private void OnDisable()
    {
        _gameOverScreen.RestartButtonClick -= OnRestartButtonClick;
        _boll.GameOver -= OnGameOver;
    }
    private void OnRestartButtonClick()
    {
        _gameOverScreen.Close();
        _coinGenerator.ResetPool();
        _cactusGenerator.ResetPool();
        StartGame();
    }
    private void StartGame()
    {
        Time.timeScale = 1;
        _boll.ResetPlayer();
    }
    public void OnGameOver()
    {
        Time.timeScale = 0;
        _gameOverScreen.Open();
    }
}
