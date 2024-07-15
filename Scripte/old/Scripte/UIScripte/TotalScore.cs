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

    // 게임 종료 시 호출될 메서드
    public void EndGame()
    {
        // 여기에서 게임 종료 시 전체 스코어를 표시하도록 설정
        Debug.Log("Game Over! Total Score: " + score);
        // 예를 들어, UI에 게임 종료 메시지와 스코어를 표시하려면 다음과 같이 할 수 있습니다.
        text.text = "Game Over! Total Score: " + score.ToString();
    }

    public void SetText()
    {
        text.text = " " + score.ToString();
    }
}
