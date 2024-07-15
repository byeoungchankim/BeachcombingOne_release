using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreManager : MonoBehaviour
{
    public Text finalScoreText; // 최종 스코어를 표시할 Text 오브젝트

    public void ShowFinalScore(int finalScore)
    {
        // 최종 스코어를 Text 오브젝트에 표시
        finalScoreText.text = "Final Score: " + finalScore.ToString();

        // UI(Text)를 활성화하여 보이게 함
        finalScoreText.gameObject.SetActive(true);
    }
}
