using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    private int score = 0;

    private void Start()
    {
        SetText();
    }

    public int GetScore()
    {
        score += 100;
        SetText();
        return score;
    }

    public int GetCurrentScore()
    {
        return score;
    }

    public void SetText()
    {
        text.text = " " + score.ToString();
    }

}

