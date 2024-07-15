using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreManager : MonoBehaviour
{
    public Text finalScoreText; // ���� ���ھ ǥ���� Text ������Ʈ

    public void ShowFinalScore(int finalScore)
    {
        // ���� ���ھ Text ������Ʈ�� ǥ��
        finalScoreText.text = "Final Score: " + finalScore.ToString();

        // UI(Text)�� Ȱ��ȭ�Ͽ� ���̰� ��
        finalScoreText.gameObject.SetActive(true);
    }
}
