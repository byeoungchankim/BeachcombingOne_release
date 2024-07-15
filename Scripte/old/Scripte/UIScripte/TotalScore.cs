using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public Text text;
    int score = 0;

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

    // ���� ���� �� ȣ��� �޼���
    public void EndGame()
    {
        // ���⿡�� ���� ���� �� ��ü ���ھ ǥ���ϵ��� ����
        Debug.Log("Game Over! Total Score: " + score);
        // ���� ���, UI�� ���� ���� �޽����� ���ھ ǥ���Ϸ��� ������ ���� �� �� �ֽ��ϴ�.
        text.text = "Game Over! Total Score: " + score.ToString();
    }

    public void SetText()
    {
        text.text = " " + score.ToString();
    }
}
