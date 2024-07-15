using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Text scoreText;

    private int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateScoreText();
    }

    public int GetScore()
    {
        score += 100;
        UpdateScoreText();
        return score;
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
